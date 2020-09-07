using HappyCamp.DataAccess.Context;
using HappyCamp.DataAccess.Converters;
using HappyCamp.DataAccess.Entities;
using HappyCamp.DataAccess.Service;
using HappyCamp.Domain.DTOs;
using HappyCamp.Domain.Facades;
using HappyCamp.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyCamp.DataAccess.Repositories
{
    public sealed class PersonRepository : Repository<Person>, IPersonFacade
    {
        private IConverter ToEntity = new PersonToPersonEntityConverter();
        private IConverter FromEntity = new PersonEntityToPersonConverter();

        public IEnumerable<Person> GetByAge(ushort age)
        {
            var targetYear = DateTime.Now.Year - age;

            using (var context = new SQLServerContext())
            {
                return context.Persons
                    .Where(prsn => prsn.BirthDate.Year == targetYear)
                    .Select(FromEntity.Convert<PersonEntity, Person>)
                    .AsEnumerable();
            }
        }

        public Person GetByEmail(string email)
        {
            using (var context = new SQLServerContext())
            {
                return context.Persons
                    .Where(prsn => email.Equals(prsn.Email))
                    .Select(FromEntity.Convert<PersonEntity, Person>)
                    .FirstOrDefault();
            }
        }

        public IEnumerable<Person> GetByNationality(string nationality)
        {
            using (var context = new SQLServerContext())
            {
                return context.Persons
                    .Where(prsn => nationality.Equals(prsn.Nationality))
                    .Select(FromEntity.Convert<PersonEntity, Person>)
                    .AsEnumerable();
            }
        }

        protected override IService<Person> GetService()
        {
            return new PersonSQLService();
        }
    }
}
