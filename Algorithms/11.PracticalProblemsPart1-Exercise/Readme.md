<h1>Exercises: Problem Solving</h1>
<p>This document defines the <strong>homework</strong> assignments for the <a href="https://softuni.bg/opencourses/algorithms">"Algorithms" course @ Software University</a>.</p>
<h1>1.&nbsp; Parking Zones</h1>
<p>You want to find the best place to park your car, in order to quickly go to the nearby store. We are given <strong>n</strong> parking zones, each parking zone has <strong>x</strong> and <strong>y</strong> (the coordinates of the top left corner of the parking zone), <strong>width</strong>, <strong>height </strong>and a price<strong> p &ndash; </strong>the price for <strong>a minute stay </strong>at the zone. We are also provided <strong>s</strong> free parking spaces in the form of their top left <strong>x</strong> and <strong>y</strong> coordinates, every parking space belonging to a parking zone. We also know that each block on the coordinate system is a square with dimensions exactly <strong>1 x 1</strong>. Additionally, we are given a target block <strong>t </strong>(given as its top left <strong>x</strong> and <strong>y</strong> coordinates) and a constant <strong>k </strong>which tells us the number of seconds needed to traverse <strong>one block</strong> (1 unit on the coordinate system). For the purposes of calculating the distance to <strong>t</strong>, movement is considered possible only in the four <strong>major directions</strong> (north, south, east, west), <strong>moving diagonally is</strong> <strong>NOT allowed</strong>.</p>
<p>The goal is to find the parking space, from which the journey to the target block <strong>t </strong>and back costs the <strong>least amount of money</strong>, if multiple such spaces exist then we are to find the one that takes us the <strong>least amount of time</strong> to reach <strong>t.</strong> For the purpose of calculating the price for the stay, the minutes needed to reach the point and come back have to be <strong>rounded up</strong>, because for 2 minutes and 5 seconds we are taxed for 3 minutes.</p>
<h3>Input</h3>
<ul>
<li>On the<strong> first line,</strong> we receive the number <strong>n</strong> that shows us the number of parking zones that we will receive.</li>
<li>On the next <strong>n</strong> lines, we receive the zones in the format "<strong>[Name of Zone]: [x], [y], [width], [height], [price/min]</strong>"</li>
<li>On the next line, we receive a list of the free parking spots in the format "<strong>x, y</strong>" separated by "<strong>;</strong>"</li>
<li>On the next line, we receive the target point <strong>t</strong>, again in format "<strong>x, y</strong>"</li>
<li>On the last line, the constant <strong>k </strong>is given, showing us<strong> the time in seconds needed to traverse a single block </strong>on the coordinate system.</li>
</ul>
<h3>Output</h3>
<ul>
<li>On a single line print the string &ldquo;<strong>Zone Type: [Zone Name]; X: [x]; Y: [y]; Price: [Price]</strong>&rdquo;, where <strong>[Zone Name] </strong>is the name of the zone in which the parking space with the best price and time to <strong>t </strong>is, <strong>[x]</strong> and <strong>[y]</strong> are the top left coordinates of the parking space and <strong>[price] </strong>is the price we&rsquo;ll have to pay for the stay <strong>formatted to 2 decimal places</strong> <strong>(pay attention that the number of minutes needed to reach the point and come back has to be rounded up, because for 2 minutes and 5 seconds we are taxed for 3 minutes).</strong></li>
</ul>
<h3>Constraints</h3>
<ul>
<li>Each parking space will always be part of a defined parking zone.</li>
<li>Parking zones will never overlap.</li>
<li>There will never be 2 parking spaces with equal distance from the target in the same zone.</li>
<li>There will never be 2 parking spaces with the best price and time from the target point.</li>
<li>The number of zones <strong>n</strong> will always be a whole number in the range <strong>[1&hellip;10].</strong></li>
<li>The price for staying a minute at a parking zone <strong>p </strong>will always be a real number in the range <strong>[1&hellip;1000].</strong></li>
<li>All input values except<strong> p </strong>and<strong> n</strong> will always be integers in the range <strong>[1&hellip;1&nbsp;000&nbsp;000].</strong></li>
<li>Allowed time: <strong>100 ms</strong>. Allowed Memory: <strong>16 MB</strong>.</li>
</ul>
<h3>Examples</h3>
<table width="1412">
<tbody>
<tr>
<td width="704">
<p><strong>Input</strong></p>
</td>
<td width="708">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="704">
<p><strong>2<br /> Blue: 0, 0, 10, 10, 1.0<br /> Green: 0, 10, 10, 10, 0.5<br /> 1, 1; 5, 5; 1, 11; 5, 16<br /> 15, 10<br /> 20</strong></p>
</td>
<td width="708">
<p><strong>Zone Type: Green; X: 1; Y: 11; Price: 5.00</strong></p>
</td>
</tr>
<tr>
<td colspan="2" width="1412">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td colspan="2" width="1412">
<p>We find the closest parking spot to t from each zone.</p>
<p>For the <strong>Blue zone, </strong>this is the parking spot with coordinates <strong>5, 5</strong>. The total blocks we need to walk from it to the target point is <strong>14</strong>. We multiply the blocks by <strong>2 </strong>to get the number of blocks needed <strong>to reach t and return</strong>, then we multiply by the time needed for each block <strong>k </strong>(in this case <strong>20</strong>) to receive the number of seconds that we have to stay. <strong>14 * 2 * 20 = 560 </strong>/ 60 (to transform the seconds into minutes) = <strong>9 minutes and 20 seconds </strong>(since we crossed the 9 minutes&rsquo; mark, we need to pay for 10 minutes). 10 * price <strong>p </strong>for stay/min <strong>1 </strong>=<strong> 10lv.</strong></p>
<p>For the <strong>Green zone, </strong>this is the parking spot with coordinates <strong>1, 11 </strong>(we don't check <strong>[1,1]</strong> and <strong>[5, 16]</strong> because the distance from them is obviously bigger). We do the same calculations, the total number of blocks is again <strong>14</strong>, so we calculate the time<strong> 14</strong> <strong>*</strong> <strong>2</strong> for a round trip <strong>* 20</strong> for the number of seconds = <strong>560 </strong>/ 60<strong> = 9m20s</strong>, which we round up to<strong> 10</strong>, this time however the price per minute for the zone is lower, so we get<strong> 10 * 0.5 </strong>(p)<strong> = 5lv</strong>.</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Parentheses</h2>
<p>Given&nbsp;<strong>N&nbsp;pairs</strong> of parentheses, write a program to generate all combinations of well-formed parentheses.</p>
<h3>Input</h3>
<ul>
<li>On the<strong> first line,</strong> we receive the number <strong>N</strong> that shows us the number of pairs of brackets.</li>
</ul>
<h3>Output</h3>
<ul>
<li>Print all correctly formed parentheses. The order of output does not matter.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li><strong>N</strong> will be in the range <strong>[1&hellip;20].</strong></li>
<li>Allowed time: <strong>150 ms</strong>. Allowed Memory: <strong>32 MB</strong>.</li>
</ul>
<h3>Examples</h3>
<table width="254">
<tbody>
<tr>
<td width="103">
<p><strong>Input</strong></p>
</td>
<td width="152">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="103">
<p><strong>3</strong></p>
</td>
<td width="152">
<p><strong>((())) </strong></p>
<p><strong>(()()) </strong></p>
<p><strong>(())() </strong></p>
<p><strong>()(())</strong></p>
<p><strong>()()()</strong></p>
</td>
</tr>
<tr>
<td width="103">
<p><strong>2</strong></p>
</td>
<td width="152">
<p><strong>(())</strong></p>
<p><strong>()()</strong></p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Towns</h2>
<p>You are given <strong>N</strong> towns and you should find a path in them that satisfies few conditions. In each of the towns there are fixed number of <strong>citizens</strong> (between 1 and 1,000,000,000, inclusive).</p>
<p>The towns can be visited <strong>only in the order they are given</strong> on the console. You are not obligated to start the traversing from the first town. You can also <strong>skip some of the towns</strong> but you are not allowed to visit a town more than once.</p>
<p>For example if we have towns Sofia, Plovdiv, Varna and Burgas <strong>you can visit:</strong></p>
<ul>
<li>Sofia, Varna, Burgas (by skipping Plovdiv)</li>
<li>Plovdiv, Burgas (by starting from Plovdiv and skipping Varna)</li>
<li>Sofia, Plovdiv, Varna, Burgas (by visiting every town)</li>
<li>etc.</li>
</ul>
<p>You are <strong>not allowed</strong> to visit the towns in wrong order. For example:</p>
<ul>
<li>Varna, Sofia is <strong>not</strong> allowed because Varna should be visited after Sofia in the given order</li>
<li>Sofia, Varna, Sofia is <strong>not</strong> allowed because you are visiting Sofia for a second time</li>
<li>etc.</li>
</ul>
<p>You should satisfy <strong>one more condition</strong> when traversing towns. If you divide the path into 2 sub-paths that share one common town (part of the original path) such that the last town of the first path is the first town of the second path, then all number of citizens in the first path should be in ascending order and all number of citizens (increasing number of citizens) in the second path should be in descending order (decreasing number of citizens). Yeah.</p>
<p>For example look at the first example below. The path Pleven, Burgas, Varna, Sofia, Ruse, StaraZagora satisfies this condition (in fact, it satisfies all conditions) because we can divide the path into 2 sub-paths (first: Pleven, Burgas, Varna, Sofia; second: Sofia, Ruse, StaraZagora) and the first path has increasing number of citizens and the second path has decreasing number of citizens.</p>
<p>Write a program that finds <strong>the longest path that satisfies the given conditions</strong>.</p>
<h3>Input</h3>
<ul>
<li>The input data should be read from the console.</li>
<li>The number of towns <strong>N</strong> will be given on the first input line.</li>
<li>On each of the next <strong>N</strong> lines there will be information for one of the towns in the order they can be traversed. If you split the line by a single space (&lsquo; &lsquo;) the first part of the line will contain the number of citizens in the town, and the second part of the line will contain the name of the town. See the examples below.</li>
<li>The input data will always be valid and in the format described. There is no need to check it explicitly.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output data should be printed on the console.</li>
<li>On the only output line write the longest path that satisfies the given conditions.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li><strong>N</strong> will be an integer between <strong>1</strong> and <strong>1000</strong>, inclusive.</li>
<li>The name of each town will contain only Latin letters (both lowercase (&lsquo;a&rsquo;-&rsquo;z&rsquo;) and uppercase (&lsquo;A&rsquo;-&rsquo;Z&rsquo;) are allowed)</li>
<li>The length of each town name will be between <strong>1</strong> and <strong>20</strong></li>
<li>Each town name will be unique.</li>
<li>Allowed working time for your program:<strong> 100 ms</strong>. Allowed memory: <strong>16</strong><strong> MB</strong>.</li>
</ul>
<h3>Examples</h3>
<p>&nbsp;</p>
<table>
<tbody>
<tr>
<td width="409">
<p><strong>Input</strong></p>
</td>
<td width="264">
<p><strong>Output</strong></p>
</td>
<td width="708">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="409">
<p>8</p>
<p>108214 Pleven</p>
<p>339077 Plovdiv</p>
<p>200612 Burgas</p>
<p>334688 Varna</p>
<p>1241396 Sofia</p>
<p>92162 Sliven</p>
<p>151951 Ruse</p>
<p>137907 StaraZagora</p>
</td>
<td width="264">
<p>6</p>
<p>&nbsp;</p>
</td>
<td width="708">
<p>The longest path that satisfies all conditions contains these 6 cities:</p>
<p>Pleven (first town)</p>
<p>Burgas (bigger than Pleven)</p>
<p>Varna (bigger than Burgas)</p>
<p>Sofia (bigger than Varna)</p>
<p>Ruse (smaller than Sofia)</p>
<p>StaraZagora (smaller than Ruse)</p>
<p>(The path can be cut in 2 paths satisfying citizens count condition. Sofia is the town that divides the path into 2 other paths)</p>
</td>
</tr>
<tr>
<td width="409">
<p>4</p>
<p>19906 NikiTown</p>
<p>19832 EvlogiTown</p>
<p>19894 IvoTown</p>
<p>19896 DonchoTown</p>
<p>&nbsp;</p>
</td>
<td width="264">
<p>3</p>
</td>
<td width="708">
<p>You can start from EvlogiTown, then go in IvoTown and then DonchoTown.</p>
<p>If we divide the path into 2 sub-paths</p>
<p>&bull;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; EvlogiTown, IvoTown and DonchoTown</p>
<p>&bull;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DonchoTown</p>
<p>They satisfy the ascending-descending condition.</p>
</td>
</tr>
<tr>
<td width="409">
<p>3</p>
<p>2 HaxorTown</p>
<p>2 LeetTown</p>
<p>2 RoxxorTown</p>
</td>
<td width="264">
<p>1</p>
</td>
<td width="708">
<p>You can visit any of the 3 towns, but cannot move any further because of the citizens count traversing requirements</p>
</td>
</tr>
</tbody>
</table>
<h1>4.&nbsp; Shop Keeper</h1>
<p>You are the shop keeper of a store, you will be given a sequence of numbers - <strong>S</strong> representing the <strong>products</strong> <strong>you have in stock </strong>(each number representing a certain product ex. 1 = bread, 2 = flour and so on). You will also be given a <strong>list of orders </strong>placed by customers &ndash; <strong>O</strong>, represented as a sequence of numbers (each number in the list represents an order for a product of that type ex. 1 = a customer has ordered a bread, 2 = customer has ordered flour and so on). Fulfilling an order does not remove the desired product from your stock (imagine we have infinite amounts of all products in stock). After each order, you are allowed to <strong>change a single product</strong> in your stock to any product you wish, however the total amount of product types in your stock should remain constant. Knowing all orders in advance, your task is to calculate the <strong>minimum amount of changes</strong> you need to do in your stock, in order to service all of them.</p>
<h3>Input</h3>
<ul>
<li>On the first line, we receive the sequence <strong>S</strong>, each element of <strong>S </strong>will be separated from the others by a single space.</li>
<li>On the second line, we receive the list of orders <strong>O</strong>, each element of <strong>O</strong> will be separated from the others by a single space.</li>
</ul>
<h3>Output</h3>
<ul>
<li>On a single line print the <strong>minimum number of changes needed to service all orders</strong>, if it's impossible to service all of them write "<strong>impossible</strong>" instead.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The possible product types will be integer numbers in the range <strong>[1&hellip;3000].</strong></li>
<li>The sequence of products in stock - <strong>S</strong> will contain only <strong>unique</strong></li>
<li>The sequence of the products in stock - <strong>S</strong> will contain between <strong>[1&hellip;1500] </strong></li>
<li>The sequence of the orders - <strong>O</strong> will contain between <strong>[1&hellip;12000] </strong></li>
<li>Allowed time: <strong>140 ms</strong>. Allowed Memory: <strong>32 MB</strong>.</li>
</ul>
<h3>Examples</h3>
<table width="1412">
<tbody>
<tr>
<td width="896">
<p><strong>Input</strong></p>
</td>
<td width="516">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="896">
<p>1 2 3 4</p>
<p>1 2 2 5 1 3</p>
</td>
<td width="516">
<p>1</p>
</td>
</tr>
<tr>
<td colspan="2" width="1412">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td colspan="2" width="1412">
<p>We start with item types 1, 2, 3 and 4 in stock, the first order comes and it wants an item type <strong>1</strong>, checking our stock we have the item so we fulfill the order. After fulfilling an order we have the option to change an item type in our stock, looking ahead in the list of orders we see that the next order is for an item type <strong>2</strong>, as we already have that item type in stock we decide not to change anything.</p>
<p><strong>After Order 1 -&gt; No exchange</strong></p>
<p>The second order comes in, since we have <strong>2</strong> in stock, we fulfill that order. We are again offered the chance to change an item type in stock, looking ahead we see the next order is for a <strong>2</strong> as well, having the <strong>2</strong> in stock we decide not to change anything again.</p>
<p><strong>After Order 2 -&gt; No exchange</strong></p>
<p>The third order comes in, it is for item type <strong>2</strong> again, so we fulfill it. Looking ahead in the order list we see the next order is for a <strong>5</strong>, since we don't have it in stock we have to exchange an item type for it. In this case we have two good choices, we can either change the <strong>2</strong> or the <strong>4</strong>, as we won't need them anymore. We arbitrarily choose to exchange the <strong>2</strong>.</p>
<p><strong>After Order 3 -&gt; Exchange 2 for 5</strong>.</p>
<p><strong>Stock after exchange:</strong> <strong>1 5 3 4</strong></p>
<p>The fourth order comes &ndash; it's for a <strong>5</strong>, since we exchanged the <strong>2</strong> for it we manage to service the order. Looking ahead, the next item is a <strong>1</strong>, since we have it we don't change anything.</p>
<p><strong>After Order 4 -&gt; No exchange</strong></p>
<p>The fifth order comes in for a <strong>1</strong>, we have it in stock so we fulfill it. Looking ahead the last order is for a <strong>3</strong>, as we also have that in stock we skip any changes again.</p>
<p><strong>After Order 5 -&gt; No exchange</strong></p>
<p>The sixth and last order comes in for a <strong>3</strong>, we have it in stock so we fulfill it. Having fulfilled all orders we write the number of changes we did <strong>1</strong>.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1412">
<tbody>
<tr>
<td width="896">
<p><strong>Input</strong></p>
</td>
<td width="516">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="896">
<p>5 3 1 8</p>
<p>8 10 13 13 5 3 1 13 3 8 14 10</p>
</td>
<td width="516">
<p>5</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1412">
<tbody>
<tr>
<td width="896">
<p><strong>Input</strong></p>
</td>
<td width="516">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="896">
<p>5 6 7 8</p>
<p>1 6 6 6 8</p>
</td>
<td width="516">
<p>impossible</p>
</td>
</tr>
<tr>
<td colspan="2" width="1412">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td colspan="2" width="1412">
<p>We take a look at the first order &ndash; 1, we don't have it in stock so we immediately fail the order, thus we print "<strong>impossible</strong>".</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>