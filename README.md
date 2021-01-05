#  [Deprecation Notice]

The running service on the Azure function has been deprecated - in order to continue using the tool, please host the service on your own personalised hosted solution. 

## This deprecation only affects users who had been using the service hosted on telegram-ffg public endpoint. If you already self-hosted this service, please ignore the alert. 

#  Instructions

## Deploy to Server 
 1. Setup a Linux/Windows/OSX Server.
 2. Install [.NET Core](https://www.microsoft.com/net/core).
 3. Clone this Repository or download the latest archieve.
 
### Build the Bot (skip if you downloaded the release)
 1. Clone the repository.
 2. Build the appliication by running one of the following commands:

```
# PowerShell
./build.ps1 -Target Publish

# Bash
./build.sh -Target Publish
```
This publishes the application as zip and folder int the `output` folder.

## Configure the Settings
The Directory `Telegram.Bot.Web` contains two config files:
 1. `appsetings.json` here you can define the config of your bot. All settings can also be configured via Environment variables of the same name.
     - `Telegram:JiraBot:Token` The token of the Telegram bot obtained by [@botfather](https://telegram.me/BotFather).
     - `Telegram:JiraBot:WebToken` Some random secret which is appended to the url. For examle `123456789`.
     - `Telegram:JiraBot:Endpoint` The url where bot messages are processed. For example `https://jira.bot/api/jirabot/update/123456789`. 
     - `Telegram:JiraBot:JiraWebhookUrl` The url where jira webhooks are processed. For examle `https:/jira.bot/api/jirabot/webhook/`.
     - `ConnectionString:TelegramSQLConnection` SQL Connection string where the chat-webhook mapping is saved.
     
 2. `web.config` here you can modify the webserver settings. For more information visit https://support.microsoft.com/EN-US/help/815178.
 
 
## Run the Bot
You can simply run the bot by running `dotnet Telegram.Web.dll`.
If you want to run the bot as service here are some additional documentations:
  - [Windows](https://docs.microsoft.com/en-us/aspnet/core/hosting/windows-service)
  - [Unix](http://pmcgrath.net/running-a-simple-dotnet-core-linux-daemon)
  
If you want to run the webservice behind a reverse proxy you can find more information [here](https://docs.microsoft.com/en-us/aspnet/core/publishing/linuxproduction?tabs=aspnetcore2x).
   

[![Built with Nuke](http://nuke.build/squared)](https://nuke.build)  
