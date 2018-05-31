<h1>Lab: Problem Solving</h1>
<p>This document defines the <strong>in-class exercise</strong> assignments for the <a href="https://softuni.bg/opencourses/algorithms">"Algorithms" course @ Software University</a>.</p>
<h2>1.&nbsp;&nbsp; Elections</h2>
<p>You are given the results from the elections. There are <strong>N</strong> <strong>parties</strong> that have enough votes and are given seats in the parliament. You are given the seats for each one of the parties. For the parties to have <strong>majority</strong> in the parliament they <strong>need at least K seats</strong> (that means <strong>K</strong> or more seats). Parties can combine with each other in order to have <strong>K</strong> or more seats together.</p>
<p>Write a program to find the number of all possible combinations of parties with sum of seats <strong>K</strong> or more.</p>
<h3>Input</h3>
<ul>
<li>The input data should be read from the console.</li>
<li>On the first input line, there will be the number <strong>K</strong>.</li>
<li>On the second input line, there will be the number</li>
<li>On each of the next <strong>N</strong> lines there will be the number of the seats for each of the <strong>N</strong></li>
<li>The input data will always be valid and in the format described. There is no need to check it explicitly.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output data should be printed on the console.</li>
<li>On the only output line write the number of all possible combinations of parties with sum of seats <strong>K</strong> or more.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li><strong>N</strong> will be an integer between 1 and 100, inclusive.</li>
<li>The number of seats for each party will be an integer between 1 and 1000, inclusive.</li>
<li><strong>K</strong> will be an integer between 1 and 100 000, inclusive.</li>
<li>Allowed working time for your program: 0.30 seconds. Allowed memory: 32</li>
</ul>
<h3>Examples</h3>
<table width="1411">
<tbody>
<tr>
<td width="103">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
<td width="1184">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="103">
<p>10</p>
<p>3</p>
<p>10</p>
<p>4</p>
<p>2</p>
</td>
<td width="125">
<p>4</p>
</td>
<td width="1184">
<p>If we name the parties A(10), B(4) and C(2), then the number of all possible combinations of parties with sum of seats 10 or more is exactly <strong>4</strong>:</p>
<p>&nbsp;</p>
<p>A (10), AB (14), ABC (16), AC (12)</p>
</td>
</tr>
<tr>
<td width="103">
<p>121</p>
<p>8</p>
<p>84</p>
<p>39</p>
<p>38</p>
<p>23</p>
<p>19</p>
<p>15</p>
<p>11</p>
<p>11</p>
</td>
<td width="125">
<p>128</p>
</td>
<td width="1184">
<p>If we name the parties A(84), B(39), C(38), D(23), E(19), F(15), G(11) and H(11), then the number of all possible combinations of parties with sum of seats 121 or more is exactly <strong>128</strong>:</p>
<p>&nbsp;</p>
<p>AB, ABC, ABCD, ABCDE, ABCDEF, ABCDEFG, ABCDEFGH, ABCDEFH, ABCDEG, ABCDEGH, ABCDEH, ABCDF, ABCDFG, ABCDFGH, ABCDFH, ABCDG, ABCDGH, ABCDH, ABCE, ABCEF, ABCEFG, ABCEFGH, ABCEFH, ABCEG, ABCEGH, ABCEH, ABCF,</p>
<p>&hellip;</p>
<p>BCDFG, BCDFGH, BCDFH, BCDGH, BCEFG, BCEFGH, BCEFH</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Sum To 13</h2>
<p>You are given three number <strong>a, b </strong>and<strong> c</strong> as an input. Your task is to tell if the <strong>three numbers can be summed to</strong> <strong>13</strong>, by only <strong>changing their signs</strong>.</p>
<h3>Input</h3>
<ul>
<li>On the first line, you receive the numbers <strong>a, b </strong>and <strong>c</strong>, separated by spaces.</li>
</ul>
<h3>Output</h3>
<ul>
<li>Print "<strong>Yes</strong>" if the numbers can be summed to 13, or "<strong>No</strong>" if it is impossible.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li><strong>a</strong>, <strong>b</strong>, <strong>c</strong> will be whole numbers in the range <strong>[-1 000 000&hellip;1 000 000].</strong></li>
<li>Allowed time: <strong>100 ms</strong>. Allowed Memory: <strong>16 MB</strong>.</li>
</ul>
<h3>Examples</h3>
<table width="1359">
<tbody>
<tr>
<td width="301">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
<td width="813">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="301">
<p><strong>-10 2 -1</strong></p>
</td>
<td width="246">
<p><strong>Yes</strong></p>
</td>
<td width="813">
<p>We switch the signs of -10 and -1 so that we get 10 + 2 + 1 = 13 and thus print "Yes"</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1359">
<tbody>
<tr>
<td width="301">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
<td width="813">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="301">
<p><strong>-1 10 -1</strong></p>
</td>
<td width="246">
<p><strong>No</strong></p>
</td>
<td width="813">
<p>Regardless of what sign switching we do, we can't get to 13, so we write "No"</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Lumber</h2>
<p>The Iskar river has <strong>lumber logs</strong> floating in its waters (see image below). Habibi is a beaver who wants to know if he can move from log <strong>X</strong> to log <strong>Y</strong>.</p>
<p>A log is a <strong>rectangle</strong>. It is defined by two corners: <strong>top-left </strong><strong>A</strong>(<strong>A<sub>x</sub></strong>; <strong>A<sub>y</sub></strong>) and <strong>bottom-right </strong><strong>B</strong>(<strong>B<sub>x</sub></strong>; <strong>B<sub>y</sub></strong>). Habibi can travel between two logs if they touch each other (their coordinates intersect).</p>
<p>Write a program that tells Habibi if he can travel between two arbitrary logs.</p>
<h3>Input</h3>
<ul>
<li>On the first input line you will be given the number of logs <strong>N </strong>and the number of queries<strong> M</strong> as 2 space-separated integers.</li>
<li>On the next <strong>N</strong> lines you will be given the coordinates of each log in the format "<strong>A<sub>x</sub> A<sub>y</sub> B<sub>x</sub> B<sub>y</sub></strong>".</li>
<li>On the next <strong>M</strong> lines you will be given queries in the format "<strong>X Y</strong>" where <strong>X</strong> and <strong>Y</strong> correspond to logs in the <strong>order</strong> they were given in the input (starting from <strong>1</strong>).</li>
</ul>
<h3>Output</h3>
<ul>
<li>For each query print "<strong>YES</strong>" if the two logs are connected. Otherwise, print "<strong>NO</strong>".</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The number of logs <strong>N</strong> will be an integer in the range <strong>[2..1000]</strong>.</li>
<li>The number of queries <strong>M</strong> will be an integer in the range <strong>[1..10000]</strong>.</li>
<li>All log <strong>coordinates</strong> will be valid integer numbers in the range <strong>[-100..100]</strong>.</li>
<li>Time limit: <strong>100 ms</strong>. Allowed memory: <strong>16</strong><strong> MB</strong>.</li>
</ul>
<h3>Examples</h3>
<table width="1225">
<tbody>
<tr>
<td width="404">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
<td width="696">
<p><strong>Visual</strong></p>
</td>
</tr>
<tr>
<td width="404">
<p>4 3</p>
<p>-10 30 60 10</p>
<p>-50 20 -30 -20</p>
<p>-35 60 -20 15</p>
<p>-40 -10 50 -30</p>
<p>4 2</p>
<p>3 4</p>
<p>4 1</p>
</td>
<td width="125">
<p>YES</p>
<p>YES</p>
<p>NO</p>
</td>
<td width="696">&nbsp;</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1093">
<tbody>
<tr>
<td width="404">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
<td width="564">
<p><strong>Visual</strong></p>
</td>
</tr>
<tr>
<td width="404">
<p>3 3</p>
<p>0 50 30 40</p>
<p>30 50 60 40</p>
<p>40 40 60 1</p>
<p>1 2</p>
<p>2 3</p>
<p>3 1</p>
</td>
<td width="125">
<p>YES</p>
<p>YES</p>
<p>YES</p>
</td>
<td width="564">&nbsp;</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>