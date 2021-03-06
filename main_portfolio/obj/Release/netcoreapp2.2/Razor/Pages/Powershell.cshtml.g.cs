#pragma checksum "C:\scratch\projects\WebApp\main_portfolio\Pages\Powershell.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f588aea6241aa27a75e4d64713e5398d8d3963ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(razor_pages.Pages.Pages_Powershell), @"mvc.1.0.razor-page", @"/Pages/Powershell.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Powershell.cshtml", typeof(razor_pages.Pages.Pages_Powershell), null)]
namespace razor_pages.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\scratch\projects\WebApp\main_portfolio\Pages\_ViewImports.cshtml"
using razor_pages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f588aea6241aa27a75e4d64713e5398d8d3963ea", @"/Pages/Powershell.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d45e63f997e68bd8ec1dfbd8cb9a4057c4fad5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Powershell : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\scratch\projects\WebApp\main_portfolio\Pages\Powershell.cshtml"
  
    ViewData["Title"] = "Powershell Scripts";


#line default
#line hidden
            BeginContext(115, 9155, true);
            WriteLiteral(@"
<script>


    
    $(document).ready(function () {
               

	      
        $(""button"").click(function() {
		 
            document.getElementsByClassName(""modal-body jumbotron"")[0].innerText = $(this).data(""code"");
			 

        });
        
  
  

    



    });





</script>


<div class=""AMS"">





    <h1>Powershell Scripts 	</h1>
    <p>
        Here are a few example Powershell scripts that I wrote.
        All of these PowerShell scripts have logging enabled each time it runs, it outputs the console output to a text file. At the end of each script, it also deletes all logs in the script folder and only keeps the last 20 most recent text files
        This is useful when you have a script scheduled to run daily.
    </p>
    
    <h4>API DNS Back up</h4>
    <p>
        This script makes some API calls to https://api.hackertarget.com/dnslookup so it can retrieve the DNS records for the
        target domain, builds out a row, and exports it to");
            WriteLiteral(@" a CSV file.
    </p>
    <button type=""button"" id=""test"" class=""btn btn-info btn-lg"" data-code=""
#specifies log path and file
$LogPath = 'C:\PowerShellScripts\APIDnsBackUp\DnsScriptBackUpLog'  + $(get-date -f MM-dd-yyyy) + '.txt'
#starts logging everything outputted to console
start-transcript $LogPath

#gets current date
$Date = Get-Date | Select-Object -Property Date # |  Export-Csv -Path C:\Windows\Temp\DnsAPI.csv -NoTypeInformation   -Append


#Gets DNS properties from a web page on the Internet
$ApiCall1 = Invoke-WebRequest -UseBasicParsing -Uri https://api.hackertarget.com/dnslookup/?q=[insert name here.com]        | Select-Object -Property Content
$ApiCall2 = Invoke-WebRequest -UseBasicParsing -Uri https://api.hackertarget.com/dnslookup/?q=[insert name here.com]	 | Select-Object -Property Content
$ApiCall3 = Invoke-WebRequest -UseBasicParsing -Uri https://api.hackertarget.com/dnslookup/?q=[insert name here.com]	 | Select-Object -Property Content
#creating object for row
$RForApiCal = ");
            WriteLiteral(@"New-Object -Typename PSObject
#adds data to the first row
$RForApiCal | Add-Member -MemberType NoteProperty -name Date  -Value $Date
$RForApiCal | Add-Member -MemberType NoteProperty -name ApiCall1 -Value $ApiCall1
$RForApiCal | Add-Member -MemberType NoteProperty -name ApiCall2 -Value $ApiCall2
$RForApiCal | Add-Member -MemberType NoteProperty -name ApiCall3 -Value $ApiCall3

#exports row to CSV
$RForApiCal | Export-Csv -Path 'C:\PowerShellScripts\APIDnsBackUp\MayhewDomainApiCall.csv' -Append

#gets total number of log files and subtract 20 to see if it needs to delete any
$count = ((Get-ChildItem -Path C:\PowerShellScripts\APIDnsBackUp\*.txt | select Name, LastWriteTime | Sort-Object LastWriteTime).count - 20)
#gets all log files in script directory
$DirPath = 'Folder Path to Script Location  + \*.txt'

#gets all log files names minus 20 of the newest log files are excluded
$filesToDel = Get-ChildItem -Path $DirPath | select Name, LastWriteTime | Sort-Object LastWriteTime  -descending| selec");
            WriteLiteral(@"t-object -Last $count

#loops through and deletes all old log files
foreach ($file in $filesToDel) {
#compiles path to where the log files live
$path = 'C:\PowerShellScripts\APIDnsBackUp\' + $file.Name
#removes log files
Remove-Item –path $path

}

#stops logging of the script
stop-transcript
		"" data-toggle=""modal"" data-target=""#myModal"">
        API DNS Back up Code
    </button>

    <h4> Auto FTP BackUp </h4>

    <p> This script gets the FTP username, a hashed password from a text file, the URL for the folder to download, and the destination download folder and queries the FTP server. Once it has a list of files to download, it will download them in the specified local destination folder.     </p>

    <button type=""button"" data-code=""
#specifies log path and file
$LogPath = 'C:\AutoWebSiteBackUpLog_'  + $(get-date -f MM-dd-yyyy) + '.csv'
#starts logging everything outputted to console
start-transcript $LogPath
#specifies FTP user name
$user = 'FTP User Name'
#get FTP acct pas");
            WriteLiteral(@"sword from secure hash stored in text file and converted to readable text
$password = Get-Content 'Path to secure password String' | ConvertTo-SecureString
#specifies URL + path to destination folder to download
$url = 'FTP Site to where to download folder '
#path on local computer to download files
$DestDownloadFold = 'Path of destination folder download'

#created new object containing FTP Credentials
$credentials = New-Object System.Management.Automation.PsCredential($user,$password)

#function to download FTP files
function Get_FTP_Files ($url,$credentials) {

#Makes a request to a Uniform Resource Identifier (URI).
$request = [Net.WebRequest]::Create($url)

#Represents the FTP protocol method that gets a short listing of the files on an FTP server.
$request.Method = [System.Net.WebRequestMethods+FTP]::ListDirectory

#passes the FTP credentials
$request.Credentials = $credentials

#creates response object
$response = $request.GetResponse()
		#returns the data stream from the Intern");
            WriteLiteral(@"et resource as an object
        $reader = New-Object IO.StreamReader $response.GetResponseStream()
		#returns all lines of a stream, gets all the file names
        while(-not $reader.EndOfStream) {
            $reader.ReadLine()
        }

#disposes objects to free up memory
$reader.Close()

$response.Close()


}

#calls function to get all the files to download
$files = Get_FTP_Files -url $url -credentials $credentials


#creates objects that provides  methods for sending data to and receiving data from a URL
$webclient = New-Object System.Net.WebClient
#passes credentials
$webclient.Credentials = $credentials

#gets current date
$date = Get-Date -format 'yyyy-MM-dd'
#creates destination folder name
$folderName = $date + ' Website Backup'
#creates destination folder path
$DestDownloadFold = $DestDownloadFold + $folderName + '\'

#creates that destination folder
md -Path $DestDownloadFold

#loops through the list of files to download each file
Foreach ($file in $files) {
");
            WriteLiteral(@"
#forms full URL path
$UrlFilePath = $url + $file

#forms full path of where the file is going to be downloaded
$FullDestPath = $DestDownloadFold + $file

	#downloads the file/folder
   $webclient.DownloadFile($UrlFilePath, $FullDestPath)
}


#gets total number of folders downloaded from FTP Site and subtract 20 to see if it needs to delete any
$count = ((Get-ChildItem -Path 'Path of destination download folder download' | select Name, LastWriteTime | Sort-Object LastWriteTime).count - 20)
#this is the download folder path of the FTP files
$DirPath = 'Path of FTP download folder'

#if there are folders to delete, they will go here
$filesToDel = Get-ChildItem -Path $DirPath | select Name, LastWriteTime | Sort-Object LastWriteTime  -descending| select-object -Last $count

#loops through and deletes all downloaded folders except 20 of the most recent downloads
foreach ($file in $filesToDel) {


    $path = 'Path of FTP download folder' + $file.Name
    Remove-Item –path $path -Force  -Re");
            WriteLiteral(@"curse -ErrorAction SilentlyContinue

}

#gets total number of log files and subtract 20 to see if it needs to delete any
$count = ((Get-ChildItem -Path C:\PowerShellScripts\AutoWebSiteBackUp\*.txt | select Name, LastWriteTime | Sort-Object LastWriteTime).count - 20)

$DirPath = 'Folder Path to log Location  + \*.txt'
#gets all the log files to delete
$filesToDel = Get-ChildItem -Path $DirPath | select Name, LastWriteTime | Sort-Object LastWriteTime  -descending| select-object -Last $count

#loops through and deletes logs except 20 of the most recent logs
foreach ($file in $filesToDel) {


    $path = 'Folder Path to Script Location ' + $file.Name
    Remove-Item –path $path

}

#stops logging
stop-transcript
"" class=""btn btn-info btn-lg"" data-toggle=""modal"" data-target=""#myModal"">
        Auto FTP BackUp
    </button>

    <h4>Mailbox Size Report Script </h4>

    <p>This script gets all users in active directory who have a mailbox, gets their mailbox size. If their available space");
            WriteLiteral(@" / max mailbox size ratio is over 0.5, it will get added to excel report and emailed.</p>


    <button type=""button"" data-code=""
#specifies log path and file
$LogPath = 'C:\PFScripts\EmailMailBoxScript\EmailScriptLOG'  + $(get-date -f MM-dd-yyyy) + '.txt'
#starts logging everything outputted to console
start-transcript $LogPath

# creating a remote power shell session into exchange server to get exchange tools
$sessionOption = New-PSSessionOption -SkipRevocationCheck -SkipCACheck -SkipCNCheck
$Session = New-PSSession -Configurationname Microsoft.Exchange -ConnectionUri http://[server name]/powershell/  -Authentication Kerberos    -AllowRedirection -SessionOption $sessionOption

Import-PSSession $Session

#imports exchange tools needed for script
Add-PSSnapin Microsoft.Exchange.Management.PowerShell.E2010

#gets a list of all users and their email
$AdUsers = Get-Recipient -RecipientType usermailbox -Filter {EmailAddresses -like '*");
            EndContext();
            BeginContext(9271, 199, true);
            WriteLiteral("@[domain_Name here].com\'} | Select name, PrimarySmtpAddress, SamAccountname\r\n\r\n#declares array for data storage\r\n#MailBoxStatisticsReport will store current mailbox sizes\r\n$MailBoxStatisticsReport = ");
            EndContext();
            BeginContext(9471, 132, true);
            WriteLiteral("@()\r\n#this will store people are going to be emailed to IT for their mailbox size ratio for being too big\r\n$MailBoxWarnUserReport = ");
            EndContext();
            BeginContext(9604, 7216, true);
            WriteLiteral(@"@()

#loops through all list one user at a time
Foreach ( $user in $AdUsers ) {


    #gets total mailbox size
    $TotalSizeMB = Get-MailboxStatistics $user.SamAccountname | Select TotalItemSize

    #gets current mailbox size
    $SgleUsrMBStatistic = Get-Mailbox $user.SamAccountname

    #depending on how the mailbox size is get, this checks for that by checking for a flag
    If ($SgleUsrMBStatistic.UseDatabaseQuotaDefaults -eq $TRUE ) {

            #gets the database  default size
            $temp =  Get-MailboxDatabase -Server ex1 | select ProhibitSendReceiveQuota
            #stores that value later to be used
            $SgleUsrMBStatistic.prohibitsendreceivequota =  $temp.ProhibitSendReceiveQuota.Tostring()

            #$SgleUsrMBStatistic.prohibitsendreceivequota = '2.3 gb'
    }

    #did this to filter out rows that did not contain email addresses
    If ($SgleUsrMBStatistic.prohibitsendreceivequota.ToString() -ne $null) {

    #creating object for row
    $row = New");
            WriteLiteral(@"-Object -Typename PSObject
    #creating another row for adding to the oversized ratio mailbox report
    $rowForToBigMBRpt = New-Object -Typename PSObject

    #adds data to the first row
    $row | Add-Member -MemberType NoteProperty -name Name  -Value $user.Name.ToString()
    $row | Add-Member -MemberType NoteProperty -name Email -Value $user.PrimarySmtpAddress.ToString()
    $row | Add-Member -MemberType NoteProperty -name SamAccountname -Value $user.SamAccountname.ToString()
    $row | Add-Member -MemberType NoteProperty -name MailBoxSize -Value $TotalSizeMB.TotalItemSize.ToString()
    $row | Add-Member -MemberType NoteProperty -name MaxMailBoxSize -Value $SgleUsrMBStatistic.prohibitsendreceivequota.ToString()

    #regular expression to pull data value from string for current mailbox size
    $TotalSizeMbINT = [regex]::matches($TotalSizeMB.TotalItemSize.ToString(),'\d+.GB|\d+\.\d+.GB|\d+.MB|\d+\.\d+.MB').value
    #splits data value into an array based on space EX: 1gb to 1, Gb
    $Tota");
            WriteLiteral(@"lSizeMbINT = $TotalSizeMbINT.split()


     #determines if data value is GB or MB, this will later be used to calculate ratio differently if MB
    $TotalSizeMB_GBorMB =  [regex]::matches($TotalSizeMB.TotalItemSize.ToString(), 'GB|MB').value
     #regular expression to pull data value from string for MAX mailbox size
    $MaxMBSizeInt =   [regex]::matches($SgleUsrMBStatistic.prohibitsendreceivequota.ToString(),'\d+.GB|\d+\.\d+.GB|\d+.MB|\d+\.\d+.MB').value
      #splits data value into an array based on space EX: 1gb to 1, Gb
    $MaxMBSizeInt = $MaxMBSizeInt.split()

   #if value is MB, it needs to be converted before the ratio can be calculated, Gb is already in that format
    If ($TotalSizeMB_GBorMB -eq 'MB') {
    #used for testing purposes
     $TotalSizeMbINT[0]

    # converts the MB value to a GB format (decimal)
         $TotalSizeMbINT = $TotalSizeMbINT[0] / 1000



    }
    #calculates the Mailbox ratio
    $MBRatio =   $TotalSizeMbINT[0] / $MaxMBSizeInt[0]

      #if rati");
            WriteLiteral(@"o over .5, it builds another row to be added to the Oversized Mailbox ratio email attachment report
     If ($MBRatio -ge .5) {

        $rowForToBigMBRpt | Add-Member -MemberType NoteProperty -name Name  -Value $user.Name.ToString()
        $rowForToBigMBRpt | Add-Member -MemberType NoteProperty -name Email -Value $user.PrimarySmtpAddress.ToString()
        $rowForToBigMBRpt | Add-Member -MemberType NoteProperty -name ADname -Value $user.SamAccountname.ToString()
        $rowForToBigMBRpt | Add-Member -MemberType NoteProperty -name MailBoxSize -Value $TotalSizeMB.TotalItemSize.ToString()
        $rowForToBigMBRpt | Add-Member -MemberType NoteProperty -name MaxMailBoxSize -Value $SgleUsrMBStatistic.prohibitsendreceivequota.ToString()
        $rowForToBigMBRpt | Add-Member -MemberType NoteProperty -name MailBoxRatio -Value $MBRatio
        #adds row to the report
        $MailBoxWarnUserReport += $rowForToBigMBRpt


     }



    #adds first row to Current MailBoxStatisticsReport
    $MailBox");
            WriteLiteral(@"StatisticsReport += $row

    }

#resets all the variables
$TotalSizeMB = $null
$SgleUsrMBStatistic  = $null
$temp  = $null
$row = $null
$rowForToBigMBRpt = $null
$TotalSizeMbINT = $null
$TotalSizeMB_GBorMB = $null
$MaxMBSizeInt = $null
$TotalSizeMbINT = $null
$MBRatio = $null


}


#preparing the body of email
$body = $MailBoxWarnUserReport

#exporting array to be reattached to email as a CSV
$MailBoxWarnUserReport | Export-Csv -Path 'C:\XXXXXXX\OversizedMailBoxUsers.csv'

#send email if there are any mailbox ratios over 50%
    If ($MailBoxWarnUserReport.MailBoxRatio[0] -ge 0.5) {

    #sends the actual email
    Send-MailMessage -To 'email address to email' -From 'From sending email address' -Subject 'Mail Box Ratio User Over Usage' -Body ' ' -SmtpServer ex1  -UseSSL -Attachments 'C:\Windows\temp\OversizedMailBoxUsers.csv'

    }


#kills remote power shell session
Remove-PSSession -Session $Session


#gets total number of log files and subtract 20 to see if it needs ");
            WriteLiteral(@"to delete any
$count = ((Get-ChildItem -Path C:\PFScripts\EmailMailBoxScript\*.txt | select Name, LastWriteTime | Sort-Object LastWriteTime).count - 20)
#path of where the script lives
$DirPath = 'Path of where the script lives\*.txt'

#gets all log files names minus 20 of the newest log files are excluded
$filesToDel = Get-ChildItem -Path $DirPath | select Name, LastWriteTime | Sort-Object LastWriteTime  -descending| select-object -Last $count

#loops through and deletes all old log files
foreach ($file in $filesToDel) {

	#compiles path to where the log files live
    $path = 'Path of where the script lives\' + $file.Name
   #removes log files
   Remove-Item –path $path

}




#stops logging of the script
stop-transcript
		"" class=""btn btn-info btn-lg"" data-toggle=""modal"" data-target=""#myModal"">
        Mailbox Size Report Code
    </button>

    <h4> Expired Password Emailing Script   </h4>

    <p>This script will gets all users and their password expiration dates for their Ac");
            WriteLiteral(@"tive Directory accounts. Depending when their password expires, it will sent a email with a friendlily reminder stating please change your password before it expires. If there are any users that are expired, it will email a specified email with an attachment of the expired accounts. This lets us know who could of possibly left the company and did not inform the IT department</p>

    <button type=""button"" data-code=""
#specifies log path and file
$LogPath = 'C:\ExpPassEmailUsrsLOG'  + $(get-date -f MM-dd-yyyy) + '.txt'
#starts logging everything outputted to console
start-transcript $LogPath

# bypass this error Send-MailMessage : The remote certificate is invalid according to the validation procedure
[System.Net.ServicePointManager]::ServerCertificateValidationCallback = { return $true }



#gets the Name, AD account name, email address, and AD attribute - UserPasswordExpiryTimeComputed (tells when the password is going to expire)
$results = Get-ADUser  -filter {Enabled -eq $True -and PasswordNe");
            WriteLiteral("verExpires -eq $False -and emailaddress -like \'*");
            EndContext();
            BeginContext(16821, 199, true);
            WriteLiteral("@[Insert Domain Name].com\'} –Properties \'DisplayName\', \'SamAccountName\', \'Emailaddress\',\'msDS-UserPasswordExpiryTimeComputed\' | Select-Object -Property \'Displayname\',\'SamAccountName\', \'Emailaddress\',");
            EndContext();
            BeginContext(17021, 398, true);
            WriteLiteral(@"@Name='ExpiryDate';Expression=([datetime]::FromFileTime($_.'msDS-UserPasswordExpiryTimeComputed')}}


#gets the date of when the password is going to expire
$EndDate = $results.ExpiryDate[0]

#gets current date
$StartDate=(GET-DATE)

#gets th time difference between the 2 dates
$TimeResults = NEW-TIMESPAN –Start $StartDate –End $EndDate


#declares some arrays
$ExpiredPassUsrRpt = ");
            EndContext();
            BeginContext(17420, 33, true);
            WriteLiteral("@()\r\n\r\n$AboutExpiredPassUsrRpt = ");
            EndContext();
            BeginContext(17454, 6379, true);
            WriteLiteral(@"@()

#loops through all the user in results
foreach ($user in $results) {

#gets the date of when the password is going to expire
$EndDate = $user.ExpiryDate
#gets current date
$StartDate = (GET-DATE)
#gets th time difference between the 2 dates
$TimeResults = NEW-TIMESPAN –Start $StartDate –End $EndDate

#declares subject of email
$sub = 'Your Windows Password Expires in ' + $TimeResults.Days + ' Days'
#declares Body of the email
$body = 'Hello ' + $user.Displayname + ',
' + 'Your Windows Password Expires in ' + $TimeResults.Days + ' days. Please press and hold CTRL + ALT + DELETE on your key board and select 'Change A Password' option to change your password
   -IT BOT'

#checks if password will expire in 14 days
if ($TimeResults.Days -eq 14) {
#sends email
Send-MailMessage  -To $user.Emailaddress -bcc 'Insert email address here ' -From 'Insert email address here ' -Subject $sub -Body $body  -SmtpServer ex1  -UseSSL

}
#checks if password will expire in 7 days
elseif ($TimeResults.");
            WriteLiteral(@"Days -eq 7) {

#sends email
Send-MailMessage -To $user.Emailaddress -bcc 'Insert email address here ' -From 'Insert email address here ' -Subject $sub -Body $body  -SmtpServer ex1  -UseSSL
}

#checks if password will expire in 5 days
 elseif ($TimeResults.Days -eq 5) {
#sends email
Send-MailMessage -To $user.Emailaddress -bcc 'Insert email address here ' -From 'Insert email address here ' -Subject $sub -Body $body  -SmtpServer ex1  -UseSSL

}

#checks if password will expire in 3 days
elseif ($TimeResults.Days -eq 3) {
#sends email

Send-MailMessage -To $user.Emailaddress -bcc 'Insert email address here ' -From 'Insert email address here ' -Subject $sub -Body $body  -SmtpServer ex1  -UseSSL

}
#checks if password will expire in 1 day

elseIf ($TimeResults.Days -eq 1) {

#sends email
Send-MailMessage -To $user.Emailaddress -bcc 'Insert email address here ' -From 'Insert email address here ' -Subject $sub -Body $body  -SmtpServer ex1  -UseSSL

}
	#builds out row to be added to report");
            WriteLiteral(@"
    $Row = New-Object -Typename PSObject
    $Row | Add-Member -MemberType NoteProperty -name Displayname -Value $user.Displayname
    $Row | Add-Member -MemberType NoteProperty -name ExpiryDate -Value $user.ExpiryDate
    $Row | Add-Member -MemberType NoteProperty -name Emailaddress -Value $user.Emailaddress
    $Row | Add-Member -MemberType NoteProperty -name DaysTilExp -Value $TimeResults.Days
    #adds users info to report
    $AboutExpiredPassUsrRpt += $Row

}

#filters out users who have expired passwords
$ExpiredPassUsrRpt = $AboutExpiredPassUsrRpt | WHERE-OBJECT {$_.DaysTilExp -LT 0}

#checks if the list is not empty
If  ( ![string]::IsNullOrEmpty($ExpiredPassUsrRpt.DaysTilExp[0]) ) {
#ignores validation check so it can send out an email
[System.Net.ServicePointManager]::ServerCertificateValidationCallback = { return $true }
#exports expired report to CSV
$ExpiredPassUsrRpt | Export-csv -Path 'C:\Windows\Temp\ExpiredPassUsrRpt.csv'
#sends out the email
Send-MailMessage -To 'Inser");
            WriteLiteral(@"t email address here ' -From 'Insert email address here ' -Subject 'Users With Expired Passwords' -Body ' ' -SmtpServer ex1  -UseSSL -Attachments 'C:\Windows\Temp\ExpiredPassUsrRpt.csv'


}

#gets total number of log files and subtract 20 to see if it needs to delete any
$count = ((Get-ChildItem -Path [insert log file folder path here]\*.txt | select Name, LastWriteTime | Sort-Object LastWriteTime).count - 20)
#path of where the script lives
$DirPath = 'insert log file folder path here\*.txt'

#gets all log files names minus 20 of the newest log files are excluded
$filesToDel = Get-ChildItem -Path $DirPath | select Name, LastWriteTime | Sort-Object LastWriteTime  -descending| select-object -Last $count

#loops through and deletes all old log files
foreach ($file in $filesToDel) {

	#compiles path to where the log files live
    $path = '[insert log path here]\' + $file.Name
	 #removes log files
    Remove-Item –path $path

}

#stops logging of the script
stop-transcript


		"" class=");
            WriteLiteral(@"""btn btn-info btn-lg"" data-toggle=""modal"" data-target=""#myModal"">
        Expired Password Emailing Script Code
    </button>

    <h4> Remove Disabled Accounts From Address Book Script </h4>

    <p>One common issue in Active Directory is when a person leaves and their windows account is disabled, their email address still shows up in the Outlook address book. This script will take all disabled accounts in Active Directory, loops through a user exception list, and sets a couple of flags in Active directory making the account disappear from the address book, and sending an email when it ran   </p>


    <button type=""button"" data-code=""
#imports the necessary libraries
Add-PSsnapin Microsoft.Exchange.Management.PowerShell.E2010
#specifies log path and file
$LogPath = '[Insert File Path]\RemoveDisabledAccountsFromAddressBookLOG'  + $(get-date -f MM-dd-yyyy) + '.txt'
#starts logging everything outputted to console
start-transcript $LogPath

#imports module needed to interface with AD
import-mo");
            WriteLiteral(@"dule activedirectory

#imports exceptions list
$users = Import-Csv -path ' [Insert File Path]\RemoveDisabledAccountsFromAddressBookExcptList.txt' -Header 'user'
#pulls a list of all disabled accounts in AD
$resultss = Search-ADAccount -AccountDisabled
#turns array into array list so items can be removed from it, by default array returned from Search-ADaccount cannot be modified
$results = New-Object System.Collections.ArrayList(,$resultss)

#loops through list of exception users and removes them from final list of users that are going to be hidden from the address book
foreach ($user in $users) {


#loops through disabled users list
for ($i = 0; $i -lt $results.count; $i++ ) {


#checking to see if these is a match
If ($user.user.trim() -eq $results.SamAccountName[$i]){

#if there is a match, it removes it from the disabled users list
    $results.removeat($i)



}

}

}

#loops through the list

foreach ($user in $results) {

#clears the AD attribute flags necessary to star");
            WriteLiteral("t hiding the user from the address book\r\nSet-ADUser $user.SamAccountName  -Clear ShowinAddressBook, msExchHideFromAddressLists\r\n\r\n#finishes the process of hiding the user by setting the final flag\r\nSet-ADUser $user.SamAccountName -Add ");
            EndContext();
            BeginContext(23834, 1353, true);
            WriteLiteral(@"@{msExchHideFromAddressLists='TRUE'}


}

#sends an email to IT to let someone know the script ran
Send-MailMessage -To '[insert email address here]' -From '[insert email address here]' -Subject 'Removed Disabled Accounts from Addressbook Script Ran' -Body ' ' -SmtpServer [insert email server here]  -UseSSL

#stops logging of the script
stop-transcript


		"" class=""btn btn-info btn-lg"" data-toggle=""modal"" data-target=""#myModal"">
        Remove Disabled Accounts From Address Book Script Code
    </button>


    <!-- Modal -->
    <div id=""myModal"" class=""modal fade"" role=""dialog"">
        <div class=""modal-dialog"">

            <!-- Modal content-->
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    <h4 class=""modal-title"">Powershell Code</h4>
                </div>
                <div class=""modal-body jumbotron"">
                    <pr");
            WriteLiteral(@"e>
				 INSERT ALL CODE HERRR! 
                    </pre>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                </div>
            </div>

        </div>
    </div>
</div>







");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.ReactWebStoreModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ReactWebStoreModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ReactWebStoreModel>)PageContext?.ViewData;
        public MyApp.Namespace.ReactWebStoreModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
