<h1>Homework: Dynamic Programming</h1>
<p>This document defines the <strong>homework assignments</strong> for the <a href="https://softuni.bg/opencourses/algorithms">"Algortihms" course @ Software University</a>. Please submit a single zip / rar / 7z archive holding the solutions (source code) of all below described problems.</p>
<h2>1.&nbsp;&nbsp; Binomial Coefficients</h2>
<p>Write a program that finds the <a href="https://en.wikipedia.org/wiki/Binomial_coefficient">binomial coefficient</a> &nbsp;for given non-negative integers n and k. The coefficient can be found recursively by adding the two numbers above using the formula:</p>
<p>However, this leads to calculating the same coefficient multiple times (a problem which also occurs when solving the Fibonacci problem recursively). Use memoization to improve performance.</p>
<p>You can check your answers using the picture below (row and column indices start from 0):</p>
<p>Examples:</p>
<table>
<tbody>
<tr>
<td width="119">
<p><strong>Input</strong></p>
</td>
<td width="396">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="119">
<p>3</p>
<p>2</p>
</td>
<td width="396">
<p>3</p>
</td>
</tr>
<tr>
<td width="119">
<p>4</p>
<p>0</p>
</td>
<td width="396">
<p>1</p>
</td>
</tr>
<tr>
<td width="119">
<p>6</p>
<p>2</p>
</td>
<td width="396">
<p>15</p>
</td>
</tr>
<tr>
<td width="119">
<p>10</p>
<p>5</p>
</td>
<td width="396">
<p>252</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Longest Zigzag Subsequence</h2>
<p>A zigzag sequence is one that alternately increases and decreases. More formally, such a sequence has to comply with one of the two rules below:</p>
<ul>
<li>Every even element is smaller than its neighbors and every odd element is larger than its neighbors, or</li>
<li>Every odd element is smaller than its neighbors and every even element is larger than its neighbors</li>
</ul>
<p>1 3 2 is a zigzag sequence, but 1 2 3 is not. Any sequence of one or two elements is zig zag.</p>
<p>Find the longest zigzag subsequence in a given sequence.</p>
<p>Examples</p>
<table>
<tbody>
<tr>
<td width="684">
<p><strong>Input</strong></p>
</td>
<td width="513">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="684">
<p>8 3 5 7 0 8 9 10 20 20 20 12 19 11</p>
</td>
<td width="513">
<p>8 3 5 0 20 12 19 11</p>
</td>
</tr>
<tr>
<td width="684">
<p>1 2 3</p>
</td>
<td width="513">
<p>1 2</p>
</td>
</tr>
<tr>
<td width="684">
<p>1 3 2</p>
</td>
<td width="513">
<p>1 3 2</p>
</td>
</tr>
<tr>
<td width="684">
<p>24 5 31 3 3 342 51 114 52 55 56 58</p>
</td>
<td width="513">
<p>24 5 31 3 342 51 114 52 55</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Dividing Presents</h2>
<p>Alan and Bob are twins. For their birthday they received some presents and now they need to split them amongst themselves. The goal is to <strong>minimize the difference between the values of the presents received by the two brothers</strong>, i.e. to divide the presents as equally as possible.</p>
<p>Assume the presents have values represented by positive integer numbers and that presents cannot be split in half (a present can only go to one brother or the other).</p>
<p>Find the minimal difference that can be obtained and print which presents each brother has received (you may only print the presents for one of them, it is obvious that the rest will go to the other brother). In the examples below Alan always takes a value less than or equal to Bob, but you may do it the other way around.</p>
<p>Examples</p>
<table>
<tbody>
<tr>
<td width="684">
<p><strong>Input</strong></p>
</td>
<td width="513">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="684">
<p>3 2 3 2 2 77 89 23 90 11</p>
</td>
<td width="513">
<p>Difference: 30</p>
<p>Alan:136 Bob:166</p>
<p>Alan takes: 11 90 23 2 2 3 2 3</p>
<p>Bob takes the rest.</p>
</td>
</tr>
<tr>
<td width="684">
<p>2 2 4 4 1 1</p>
</td>
<td width="513">
<p>Difference: 0</p>
<p>Alan:7 Bob:7</p>
<p>Alan takes: 1 4 2</p>
<p>Bob takes the rest.</p>
</td>
</tr>
<tr>
<td width="684">
<p>7 17 45 91 11 32 102 33 6 3</p>
</td>
<td width="513">
<p>Difference: 1</p>
<p>Alan:173 Bob:174</p>
<p>Alan takes: 33 32 91 17</p>
<p>Bob takes the rest.</p>
</td>
</tr>
<tr>
<td width="684">
<p>1 1 1 1 1 1 1 1 1 22</p>
</td>
<td width="513">
<p>Difference: 13</p>
<p>Alan:9 Bob:22</p>
<p>Alan takes: 1 1 1 1 1 1 1 1 1</p>
<p>Bob takes the rest.</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Sum with Unlimited Amount of Coins</h2>
<p>We have a set of coins with predetermined values, e.g. 1, 2, 5, 10, 20, 50. Given a sum S, the task is to find how many combinations of coins will sum up to S. For each value, we can use an <strong>unlimited number of coins</strong>, e.g. we can use S coins of value 1 or S/2 coins of value 2 (if S is even), etc.</p>
<p>Examples</p>
<table width="1376">
<tbody>
<tr>
<td width="485">
<p><strong>Input</strong></p>
</td>
<td width="218">
<p><strong>Output</strong></p>
</td>
<td width="673">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="485">
<p>1 2 3 4 6</p>
<p>6</p>
</td>
<td width="218">
<p>10</p>
</td>
<td width="673">
<p>The 10 combinations are:</p>
<p>6 = 6</p>
<p>6 = 4 + 2</p>
<p>6 = 4 + 1 + 1</p>
<p>6 = 3 + 3</p>
<p>6 = 3 + 2 + 1</p>
<p>6 = 3 + 1 + 1 + 1</p>
<p>6 = 2 + 2 + 2</p>
<p>6 = 2 + 2 + 1 + 1</p>
<p>6 = 2 + 1 + 1 + 1 + 1</p>
<p>6 = 1 + 1 + 1 + 1 + 1 + 1</p>
</td>
</tr>
<tr>
<td width="485">
<p>1 2 5</p>
<p>5</p>
</td>
<td width="218">
<p>4</p>
</td>
<td width="673">
<p>The 4 combinations are:</p>
<p>5 = 5</p>
<p>5 = 2 + 2 + 1</p>
<p>5 = 2 + 1 + 1 + 1</p>
<p>5 = 1 + 1 + 1 + 1 + 1</p>
</td>
</tr>
<tr>
<td width="485">
<p>1 2 5 10</p>
<p>13</p>
</td>
<td width="218">
<p>16</p>
</td>
<td width="673">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="485">
<p>1 2 5 10 20 50 100</p>
<p>100</p>
</td>
<td width="218">
<p>4563</p>
</td>
<td width="673">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Sum with Limited Amount of Coins</h2>
<p>In the previous problem, the coins represented values, not actual coins (we could take as many coins of a certain value as we wanted). In this problem, we&rsquo;ll regard the coins as actual coins, e.g. 1, 2, 5 are three coins and we can use each of them only once. We can, of course, have more coins of a given value, e.g. &ndash; 1, 1, 2, 2, 10.</p>
<p>The task is the same - find the number of ways we can combine the coins to obtain a certain sum S.</p>
<p>Examples</p>
<table width="1388">
<tbody>
<tr>
<td width="514">
<p><strong>Input</strong></p>
</td>
<td width="200">
<p><strong>Output</strong></p>
</td>
<td width="673">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="514">
<p>1 2 2 3 3 4 6</p>
<p>6</p>
</td>
<td width="200">
<p>4</p>
</td>
<td width="673">
<p>The 4 combinations are:</p>
<p>6 = 6</p>
<p>6 = 4 + 2</p>
<p>6 = 3 + 3</p>
<p>6 = 3 + 2 + 1</p>
</td>
</tr>
<tr>
<td width="514">
<p>1 2 2 5</p>
<p>5</p>
</td>
<td width="200">
<p>2</p>
</td>
<td width="673">
<p>The 2 combinations are:</p>
<p>5 = 5</p>
<p>5 = 2 + 2 + 1</p>
</td>
</tr>
<tr>
<td width="514">
<p>1 2 2 5 5 10</p>
<p>13</p>
</td>
<td width="200">
<p>2</p>
</td>
<td width="673">
<p>The 2 combinations are:</p>
<p>13 = 10 + 2 + 1</p>
<p>13 = 5 + 5 + 2 + 1</p>
</td>
</tr>
<tr>
<td width="514">
<p>50 20 20 20 20 20 10</p>
<p>100</p>
</td>
<td width="200">
<p>2</p>
</td>
<td width="673">
<p>The 2 combinations are:</p>
<p>100 = 50 + 20 + 20 + 10</p>
<p>100 = 20 + 20 + 20 + 20 + 20</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>