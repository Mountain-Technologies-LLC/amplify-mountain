/* MIT License

Copyright (c) 2023 Mountain Technologies LLC

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. */

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
