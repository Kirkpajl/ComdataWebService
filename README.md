![Comdata Logo](https://raw.githubusercontent.com/Kirkpajl/ComdataWebService/master/comdata-logo.png "Comdata Logo")

# Comdata Web Service

#### IMPORTANT NOTE:
* I am not actively maintaining this repo project.
* If you find issues - please reach out with a PR that would solve it. I would try to push NuGET with updates to help as soon as I can.
* If anyone is interested to take over as maintainer - please contact me, thanks!

---

This package allows for strongly-typed communication with the Comdata FleetCreditWS0200 
and RealTimeOnline0103 SOAP XML web services.  It handles the XML serialization, wraps 
the communication faults as Exceptions, and handles much of the duplicate code for you.

In order to be authenticated, each webservice request must include:

- The WSSE token credentials (WSS SignOn Name and Password)
- Mainframe network credentials (User Name, Password, 16-digit security code)
- Customer information (Account Code , Customer Id)

## Example Usage

### Get Card Listings

```C#
// Initialize the webservice client
var client = new FleetCreditWS0200Client();
client.SetServiceCredentials("webserviceUserName", "webservicePassword");
client.SetNetworkCredentials("networkUserName", "networkPassword);

// Declare variables for paged results                
const int pageSize = 10000;
int page = 1;

// Initialize Card Listing collection
var cards = new List<CardListingRecordV02>();

// Get the first page of records
var result = await client.CardListingV02Async(
    new[] { new AccountCodeRecord(settings.AccountCode) },
    CardListingMaskCardFlag.No,
    CardListingStatus.Active,
    CardListingSortOption.CardNumber,
    pageSize,
    page);

// Add the records to the collection
cards.AddRange(result.Records);
```

## The MIT License (MIT)

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
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.