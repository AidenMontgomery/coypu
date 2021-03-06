using System;

namespace Coypu.Queries
{
    internal class HasCssQuery : DriverScopeQuery<bool>
    {
        private readonly Driver driver;
        private readonly string cssSelector;
        public override bool ExpectedResult { get { return true; } }

        protected internal HasCssQuery(Driver driver, DriverScope scope, string cssSelector, Options options) : base(scope,options)
        {
            this.driver = driver;
            this.cssSelector = cssSelector;
        }

        public override bool Run()
        {
            return driver.HasCss(cssSelector, DriverScope);
        }
    }
}