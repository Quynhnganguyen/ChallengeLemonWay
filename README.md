# ChallengeLemonWay
Challenge link: https://gist.github.com/lemonway/4a2a22949e96863769ce91185bfc2f43#file-webservice_challenge-md
There are 3 projects in this repos.
# 1. ChallengeLemonWayAPI
This is the SOAP webservice which have **Fibonacci service** and **XmlToJson service**. I built the simple Webservice, there is not yet authentification.
For testing, you can run the Webservice on `localhost` and use Postman for sending requests. 
## Fibonacci service
Method: POST 

URL: https://localhost:44386/ChallengeLemonwayService.asmx

Body:
```
<soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">
  <soap:Body>
    <Fibonacci xmlns="http://ChallengeLemonway.org/">
      <n>100</n>
    </Fibonacci>
  </soap:Body>
</soap:Envelope>
```
## XmlToJson service
Method: POST 

URL: https://localhost:44386/ChallengeLemonwayService.asmx

Body:
```
<?xml version="1.0" encoding="utf-8"?>
<soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">
  <soap:Body>
    <XmlToJson xmlns="http://ChallengeLemonway.org/">
      <xml>&lt;TRANS>&lt;HPAY>&lt;ID>103&lt;/ID>&lt;STATUS>3&lt;/STATUS>&lt;EXTRA>&lt;IS3DS>0&lt;/IS3DS>&lt;AUTH>031183&lt;/AUTH>&lt;/EXTRA>&lt;INT_MSG/>&lt;MLABEL>501767XXXXXX6700&lt;/MLABEL>&lt;MTOKEN>project01&lt;/MTOKEN>&lt;/HPAY>&lt;/TRANS></xml>
    </XmlToJson>
  </soap:Body>
</soap:Envelope>
```
# 2. ChallengeLemonwayAPI.Tests
This is a project "Class Library" for testing these functions in ChallengeLemonwayAPI by using XUnit.

We can run the test in console with the command below:

```
packages\xunit.runner.console.2.4.1\tools\net452\xunit.console.exe ChallengeLemonwayAPI.Tests\bin\Debug\ChallengeLemonwayAPI.Tests.dll
```

# 3. ChallengeLemonwayConsumer
This is an Application Console for consuming the webservices in ChallengeLemonwayAPI.
For checking this application, there are 3 steps:
1. Build APIConsumer by Visual Studio. (After this step, you have a `ChallengeLemonwayConsumer.exe` in `ChallengeLemonwayConsumer/bin/Debug` or `ChallengeLemonwayConsumer/bin/Release` depend on your choice).
2. Run the Webservice ChuaNgotApi on `localhost`.
3. Run file `ChallengeLemonwayConsumer.exe` for testing

# 4. References
- Fibonacci algorithm: https://www.nayuki.io/page/fast-fibonacci-algorithms
- Pass xml inside parameter: https://stackoverflow.com/questions/5715404/soap-ui-how-to-pass-xml-inside-parameter
- How to consume XML WebService: https://github.com/lemonwaysas/csharp-client-directkit-xml
