using System;

namespace ProductFinderDal
{
    public class ProductFinderContext
    {

        AppConfiguration appconfig = new AppConfiguration();
        public string constr { get; set; }

        private readonly ConnectionStringConfig config;


    }
}
