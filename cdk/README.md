# Welcome to the Amplify Mountain CDK C# project!

This is created for CDK development with C#.

The `cdk.json` file tells the CDK Toolkit how to execute your app.

It uses the [.NET Core CLI](https://docs.microsoft.com/dotnet/articles/core/) to compile and execute your project.

# Requirements

1. Domain is ready for deployment in Amazon Web Service
1. Local machine has npm installed by running `npm -v`
1. Local machine has aws-sdk installed by running `npm info aws-sdk version`
1. Local machine has aws-sdk installed by running `cdk --version`
1. Local machine has an identity by running `aws sts get-caller-identity`
1. AWS Account is bootstrapped by running `cdk bootstrap --context domain=example.com`

# Comands

- `dotnet build src`                        compile the infrastructure
- `cdk deploy --context domain=example.com` deploy infrustructure stack to local machine's AWS account/region
- `cdk diff --context domain=example.com`   compare local machine's stack with local machine's AWS account/region infrustructure state
- `cdk synth --context domain=example.com`  emits the synthesized CloudFormation template

# License

MIT License

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
SOFTWARE.
