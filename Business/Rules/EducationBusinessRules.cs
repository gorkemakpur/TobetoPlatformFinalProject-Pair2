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
    public class EducationBusinessRules : BaseBusinessRules
    {
        private readonly IEducationDal _educationDal;

        public EducationBusinessRules(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public Task EnsureEducationIsNotNull(Education? education)
        {
            if (education == null)
            {
                throw new BusinessException(Messages.EducationIsNull);
            }
            return Task.CompletedTask;
        }

        public async Task VerifyEducationExistsById(Guid id, CancellationToken cancellationToken)
        {
            Education? education = await _educationDal.GetAsync(
                predicate: a => a.Id == id, enableTracking: false, cancellationToken: cancellationToken
            );
            await EnsureEducationIsNotNull(education);
        }


    }

}
