using Business.Messagess;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class ApplicationBusinessRules : BaseBusinessRules
    {
        private readonly IApplicationDal _applicationDal;

        public ApplicationBusinessRules(IApplicationDal applicationDal)
        {
            _applicationDal = applicationDal;
        }

        public Task EnsureApplicationIsNotNull(Application? application)
        {
            if (application == null)
            {
                throw new BusinessException(Messages.ApplicationIsNull);
            }
            return Task.CompletedTask;
        }

        public async Task VerifyApplicationExistsById(Guid id, CancellationToken cancellationToken)
        {
            Application? application = await _applicationDal.GetAsync(
                predicate: a => a.Id == id, enableTracking: false, cancellationToken: cancellationToken
            );
            await EnsureApplicationIsNotNull(application);
        }


    }

}
