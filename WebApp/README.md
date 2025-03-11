# Serve Web App
## Call simple web service to fill datatables.net -table


Main files:

  * WebService.asmx
  * Datapage.html
  * Simple.css


> Solution contains all files in one flat directory structure for demonstration purposes.

>


The Flow
------------

Steps to create the app:

 1. Create [WebMethod]s in WebService.asmx
 2. Create JavaScript function to call the WebService - Code below
 3. Create HTML file with DataTables to show data from WebService



~~~
function getTodaysNewUsers3() {

            var xmlHttp = new XMLHttpRequest();
            var url = "https://localhost:44392/WebService1.asmx/NewUsers";
            //var parameters = "first=s&last=d";
            var parameters = "";
            xmlHttp.open("POST", url, true);

            xmlHttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");

            xmlHttp.onreadystatechange = function () {
                if (xmlHttp.readyState == 4 && xmlHttp.status == 200) {
                    new DataTable('#example', {
                        data: loadData(xmlHttp.responseXML.documentElement), //xmlHttp.responseXML.documentElement,
                        dataType: "xml",
                        columnDefs: [
                            {
                                className: 'dtr-control',
                                orderable: false,
                                targets: 0
                            }
                        ],
                    })
                    console.log(xmlHttp.responseXML.documentElement);
                    //document.getElementById('UserModel').innerHTML += xmlHttp.responseText + "<br />";

                }
            }

            xmlHttp.send(parameters);
        }
~~~



Here's a link to [a website](http://foo.bar), to a [local
doc](local-doc.html), and to a [section heading in the current
doc](#an-h2-header). Here's a footnote [^1].

