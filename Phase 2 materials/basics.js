var http = require('http');
var today = require('./mydatemodule');


http.createServer(function (req, res) {
    
    res.writeHead(200, { 'Content-Type': "text/html" });
    res.write('Hello');

    //res.write(today.mydatetime());
    
    //res.write(req.url);
    
    res.end();
    
}).listen(8080);

