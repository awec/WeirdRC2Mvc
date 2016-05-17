# WeirdRC2Mvc
First one to fix this wins the interwebs

## Problem
The exception in the constructor of HomeController is never hit. No runtime errors, no build errors. Any requests will correctly match the request to the default route, but MVC will not find any controllers or actions that match the route. 
