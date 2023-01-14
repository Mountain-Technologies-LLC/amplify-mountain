using Amazon.CDK;
using Constructs;

namespace AmplifyMountain
{
    public class AmplifyMountainStack : Stack
    {
        /// <summary>
        /// ## This stack uses
        /// - AmplifyMountainConstruct: a construct to deploy a static website within the distributable folder called `dist`
        ///
        /// ## From terminal from location of the cdk.json file
        /// To synth stack
        /// `cdk synth --context domain=example.com`
        ///
        /// To deploy stack
        /// `cdk deploy --context domain=example.com`
        /// </summary>
        internal AmplifyMountainStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            var domain = (string)this.Node.TryGetContext("domain");

            // The code that defines your stack goes here
            new AmplifyMountainConstruct(this, "AmplifyMountainConstruct", new AmplifyMountainConstructProps
            {
                DomainName = domain
            });

            // The code that defines your stack goes here
            new AmplifyConstruct(this, "AmplifyConstruct", new AmplifyConstructProps
            {
                Name = domain
            });
        }
    }
}
