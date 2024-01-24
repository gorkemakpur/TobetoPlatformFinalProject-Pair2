using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheAspect : MethodInterception
    {
        private int _duration;
        private ICacheManager _cacheManager;

        public CacheAspect(int duration = 60) //default cache süresi
        {
            _duration = duration;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        public override void Intercept(IInvocation invocation)
        {
            //metodun ismini bul getall metodunun reflectedtype ile namespaceini(busineess.concrete) al fullname ile de manageri(announcementManager) beraberinde getir
            var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}"); //DB.Business.IAnnouncementService.GetAll(parametre)
            //metodun parametrelerini parametre değeri varsa getallın içerisine ekler 

            var arguments = invocation.Arguments.ToList();
                                                                            //parametre varsa solu yoksa sağı ekle demek bu kısım
            var key = $"{methodName}({string.Join(",", arguments.Select(x => x?.ToString() ?? "<Null>"))})";
            if (_cacheManager.IsAdd(key))
            {
                invocation.ReturnValue = _cacheManager.Get(key); //dönecek veriyi cacheden getir metod içerisindeki değer değilde bu cachedeki değeri ver gibi 
                return;
            }
            invocation.Proceed(); //yoksa metodu devam ettir
            _cacheManager.Add(key, invocation.ReturnValue, _duration); //cache'e ekle
            
        }
    }
}
