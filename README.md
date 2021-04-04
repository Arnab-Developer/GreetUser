# Greet user

This package takes a user name and return a hello message for that user. It is an 
example pattern to create nuget package with .NET

https://www.nuget.org/packages/GreetUser

Workflow (check the `.github/workflows/ci-cd.yml`)

* For pull request to `main` only build and test.
* When pull request merged in `main` then push the nuget package to GitHub package.
* When a new release has been created then push the nuget package to both GitHub 
package and nuget org.
