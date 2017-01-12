var express = require('express');
var router = express.Router();
var request = require('request');

/* GET home page. */

router.get('/', function(req, res) {
  res.render('index', { title: 'Express' });
});

router.get('/db', (req, res)=>{
    // request('http://store/', function (error, response, body) {
    // if (!error && response.statusCode == 200) {
    //     console.log(body) // Show the HTML for the Google homepage.
    //   }
    //   res.set('Content-Type', 'application/json');
    //   return res.send(200, body);
    // })
    res.json([ { date: '2017-01-01 10:01', value: 20 }, { date: '2017-01-01 11:00', value: 60 }]);
});

module.exports = router;
