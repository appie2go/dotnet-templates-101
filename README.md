# dotnet-templates-101

This repository contains various branches. All of these branches explain a part of the `dotnet new` CLI.

The main branch shows the bare basics of dotnet templates. To create a template and test it, do the following:

```pwsh
mkdir example-template
mkdir example-template/.template.config
echo "{
    `"$schema`": `"http://json.schemastore.org/template`",
    `"author`": `"Your Name`",
    `"classifications`": [ `"web api`", `"asp.net core`", `"C#`" ],
    `"identity`": `"TestController`",
    `"name`": `"Example Controller Template`",
    `"shortName`": `"controller`"
}" > example-template/.template.config/template.json
```

Inside the `example-template` folder, create the files you want the template to create when the template is used. In my case, I'll create `TestTemplate.cs`.

To install the template, use the following command:

```pwsh

mkdir MyApi
cd MyApi

# install the template for testing purposes
dotnet new install ../Templates/example-template

# create a new API in the folder
dotnet new webapi

# apply our new template
dotnet new controller
```

And that's it.

Checkout the other branches to see how:

* To apply the project namespace in your templates
* How to replace values
* Conditionally leave out files
* Conditionally leave out code
* Conditionally leave out things with computed values