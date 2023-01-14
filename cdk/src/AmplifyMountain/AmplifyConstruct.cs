/* MIT License

Copyright (c) 2022 Mountain Technologies LLC

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
using Amazon.CDK.AWS.Amplify.Alpha;
using Constructs;

namespace AmplifyMountain
{
    public class AmplifyConstructProps
    {
        public string Name;
    }

    public class AmplifyConstruct : Construct
    {
        internal AmplifyConstruct(Construct scope, string id, AmplifyConstructProps props) : base(scope, id)
        {
            // var cfnApp = new CfnApp(this, "CfnApp", new CfnAppProps() {
            //     Name = props.Name,
            //     Description = "An AWS Amplify CDK website by the team at Mountain Technologies LLC.",
            // });

            var amplifyApp = new Amazon.CDK.AWS.Amplify.Alpha.App(this, "AmplifyApp", new Amazon.CDK.AWS.Amplify.Alpha.AppProps
            {
                AppName = props.Name
            });

            new CfnOutput(this, "AmplifyConstruct", new CfnOutputProps { Value = $"Amplify" });
        }
    }
}
