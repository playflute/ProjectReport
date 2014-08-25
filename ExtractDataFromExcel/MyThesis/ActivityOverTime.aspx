<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActivityOverTime.aspx.cs" Inherits="MyThesis.ActivityOverTime" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Activity Over Time Chart</title>
    <script src="Javascript/google_js_api.js" type="text/javascript"></script>
        <script type='text/javascript'>
            google.load('visualization', '1', { 'packages': ['annotatedtimeline'] });
            google.setOnLoadCallback(drawChart);
            function drawChart() {
                var data = new google.visualization.DataTable();
                data.addColumn('date', 'Date');
                data.addColumn('number', 'How many?');
                data.addColumn('string', 'Annotation title');
                data.addColumn('string', 'Annotation context');
                data.addRows([
          [new Date(2008, 4, 1), 30000,'志刚','what'],
          [new Date(2008, 1, 2), 10000,'孙奕','good'],
          [new Date(2008, 1, 3),15000,'李丽','can'],
          [new Date(2008, 1, 4),20000,'心宇','distinction'],
          [new Date(2008, 1, 5), 15000,'王玉瑶','effcient'],
          [new Date(2008, 1, 6), 27000,'张军玲','fantasy']
        ]);

                var chart = new google.visualization.AnnotatedTimeLine(document.getElementById('chart_div'));
                chart.draw(data, { displayAnnotations: true });
            }
    </script>
</head>
<body>
<div id='chart_div' style='width: 700px; height: 240px;'></div>

</body>
</html>
