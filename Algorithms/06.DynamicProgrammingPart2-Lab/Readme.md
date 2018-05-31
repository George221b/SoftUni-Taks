<h1>Exercises: Dynamic Programming</h1>
<p>This document defines the <strong>in-class exercises</strong> assignments for the <a href="https://softuni.bg/opencourses/algorithms">"Algorithms" course @ Software University</a>.</p>
<p>For the following exercises, you are given a Visual Studio solution "<strong>Dynamic-Programming-Lab</strong>" holding portions of the source code + unit tests. You can download it from the course&rsquo;s page.</p>
<h1>Part I &ndash; Knapsack</h1>
<p>Imagine you have a bag (<strong>knapsack</strong>) and you want to fill it with as many of your most valuable items as you can. The knapsack, of course, cannot hold an infinite number of items, it has a <strong>weight limit (capacity)</strong>. Based on this capacity, you need to decide which items to put in it to maximize the <strong>value</strong> of the items in the knapsack. We&rsquo;ll assume that the value and weight of each item and the weight limit of the knapsack are all non-negative integers. This is the so-called <strong>Knapsack problem.</strong></p>
<p><strong>&nbsp;</strong></p>
<p>For judge, order the items in alphabetical order.</p>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="640">
<p><strong>Input</strong></p>
</td>
<td width="748">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="640">
<p>20</p>
<p>Item1 5 30</p>
<p>Item2 8 120</p>
<p>Item3 7 10</p>
<p>Item4 0 20</p>
<p>Item5 4 50</p>
<p>Item6 5 80</p>
<p>Item7 2 10</p>
<p>end</p>
</td>
<td width="748">
<p>Total Weight: 19</p>
<p>Total Value: 280</p>
<p>Item2</p>
<p>Item4</p>
<p>Item5</p>
<p>Item6</p>
<p>Item7</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Setup</h2>
<p>You are given a complete Main() method for this problem in the <strong>Knapsack-Problem </strong>project as well as a simple <strong>Item</strong> class. The example input is hardcoded and the output is taken care of:</p>
<p>Your task is to complete the FillKnapsack(Item[] items, int capacity) method which returns an array of Items and test it using the provided unit tests in the <strong>Knapsack-Problem.Tests</strong> project.</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Knapsack: Dynamic Programming Approach</h2>
<p>Just as with the previous problems, we&rsquo;ll solve the Knapsack problem by dividing it into sub-problems. If we have the sack&rsquo;s maximal capacity, c, we can find solutions for each capacity starting from 0 and incrementing by 1 until we reach c.</p>
<p>We need to keep track of two things &ndash; the maximal price at each unit of capacity (from 0 to c), and mark the items we want to take. Since any item can be taken or not for any given capacity, we need <strong>matrices</strong> to hold this info:</p>
<p>We will loop through each item and each capacity c and decide whether we&rsquo;ll take the item. We take an item if:</p>
<p>1) We have enough capacity to take it;</p>
<p>2) The item provides the best price compared to other items we could&rsquo;ve taken.</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Preparation</h2>
<p>To find a solution for a problem using dynamic programming, we need a starting point, something to build upon. In the previous problem, to find the LCS we had a matrix. For both strings, we had a sub-problem in which we consider empty substrings (row 0 and column 0). This was our starting point and we could build on that to find the LCSs for each combination of substrings from there on.</p>
<p>In this problem, we don&rsquo;t have that starting point yet. We need to create it. So we&rsquo;ll fill the tables for the first item &ndash; fill row 0 of both matrices and for each capacity.</p>
<p>Once we have that, we can start filling the rest of the matrices in order to find the solution.</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Find Solutions for Each Item and Unit of Capacity</h2>
<p>Having the solutions for item 0 and all possible capacities, we can complete the matrices for the rest of the items:</p>
<p>To find out whether an item is worth taking, let&rsquo;s first assume we haven&rsquo;t taken it. Essentially, the best price will be the same as the best price at the given capacity c for the previous item:</p>
<p>Then, we need to check if we have enough capacity to take it:</p>
<p>The trickiest part is to decide whether taking the item is our best option. We have a variable remainingCapacity; if the maximal price for the given item at this remaining capacity added to the current item&rsquo;s price gives us a better price than the current, the item is worth it.</p>
<p>You can think about it this way &ndash; if we take the item, what is the best price we can achieve? That would be the item&rsquo;s price plus the best price we have for the remaining capacity. If the result is larger than what we currently have (by default, we decided not to take the item), this means taking the item is better than not taking it.</p>
<p>Note that we know the value of maxPrice[i, remainingCapacity]. Since we&rsquo;re at capacity c, this means all smaller capacities have been filled already and remainingCapacity is indeed smaller, because from c we subtracted the current item&rsquo;s weight (a non-negative integer).</p>
<p>You need to complete the condition of the if-statement (make sure the item is worth it) and take the necessary actions if it is:</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Retrieve the Items Taken</h2>
<p>If you completed the above steps correctly, you should now have a complete table like this:</p>
<table width="1420">
<tbody>
<tr>
<td width="99">
<p>&nbsp;</p>
</td>
<td width="53">
<p>0</p>
</td>
<td width="54">
<p>1</p>
</td>
<td width="54">
<p>2</p>
</td>
<td width="53">
<p>3</p>
</td>
<td width="53">
<p>4</p>
</td>
<td width="65">
<p>5</p>
</td>
<td width="65">
<p>6</p>
</td>
<td width="65">
<p>7</p>
</td>
<td width="66">
<p>8</p>
</td>
<td width="66">
<p>9</p>
</td>
<td width="66">
<p>10</p>
</td>
<td width="66">
<p>11</p>
</td>
<td width="66">
<p>12</p>
</td>
<td width="66">
<p>13</p>
</td>
<td width="66">
<p>14</p>
</td>
<td width="66">
<p>15</p>
</td>
<td width="66">
<p>16</p>
</td>
<td width="66">
<p>17</p>
</td>
<td width="66">
<p>18</p>
</td>
<td width="66">
<p>19</p>
</td>
<td width="66">
<p>20</p>
</td>
</tr>
<tr>
<td width="99">
<p>Item 1</p>
<p>(5,30)</p>
</td>
<td width="53">
<p>0</p>
</td>
<td width="54">
<p>0</p>
</td>
<td width="54">
<p>0</p>
</td>
<td width="53">
<p>0</p>
</td>
<td width="53">
<p>0</p>
</td>
<td width="65">
<p>30</p>
</td>
<td width="65">
<p>30</p>
</td>
<td width="65">
<p>30</p>
</td>
<td width="66">
<p>30</p>
</td>
<td width="66">
<p>30</p>
</td>
<td width="66">
<p>30</p>
</td>
<td width="66">
<p>30</p>
</td>
<td width="66">
<p>30</p>
</td>
<td width="66">
<p>30</p>
</td>
<td width="66">
<p>30</p>
</td>
<td width="66">
<p>30</p>
</td>
<td width="66">
<p>30</p>
</td>
<td width="66">
<p>30</p>
</td>
<td width="66">
<p>30</p>
</td>
<td width="66">
<p>30</p>
</td>
<td width="66">
<p>30</p>
</td>
</tr>
<tr>
<td width="99">
<p>Item 2</p>
<p>(8,120)</p>
</td>
<td width="53">
<p>0</p>
</td>
<td width="54">
<p>0</p>
</td>
<td width="54">
<p>0</p>
</td>
<td width="53">
<p>0</p>
</td>
<td width="53">
<p>0</p>
</td>
<td width="65">
<p>30</p>
</td>
<td width="65">
<p>30</p>
</td>
<td width="65">
<p>30</p>
</td>
<td width="66">
<p>120</p>
</td>
<td width="66">
<p>120</p>
</td>
<td width="66">
<p>120</p>
</td>
<td width="66">
<p>120</p>
</td>
<td width="66">
<p>120</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>150</p>
</td>
</tr>
<tr>
<td width="99">
<p>Item 3</p>
<p>(7,10)</p>
</td>
<td width="53">
<p>0</p>
</td>
<td width="54">
<p>0</p>
</td>
<td width="54">
<p>0</p>
</td>
<td width="53">
<p>0</p>
</td>
<td width="53">
<p>0</p>
</td>
<td width="65">
<p>30</p>
</td>
<td width="65">
<p>30</p>
</td>
<td width="65">
<p>30</p>
</td>
<td width="66">
<p>120</p>
</td>
<td width="66">
<p>120</p>
</td>
<td width="66">
<p>120</p>
</td>
<td width="66">
<p>120</p>
</td>
<td width="66">
<p>120</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>160</p>
</td>
</tr>
<tr>
<td width="99">
<p>Item 4</p>
<p>(0,20)</p>
</td>
<td width="53">
<p>20</p>
</td>
<td width="54">
<p>20</p>
</td>
<td width="54">
<p>20</p>
</td>
<td width="53">
<p>20</p>
</td>
<td width="53">
<p>20</p>
</td>
<td width="65">
<p>50</p>
</td>
<td width="65">
<p>50</p>
</td>
<td width="65">
<p>50</p>
</td>
<td width="66">
<p>140</p>
</td>
<td width="66">
<p>140</p>
</td>
<td width="66">
<p>140</p>
</td>
<td width="66">
<p>140</p>
</td>
<td width="66">
<p>140</p>
</td>
<td width="66">
<p>170</p>
</td>
<td width="66">
<p>170</p>
</td>
<td width="66">
<p>170</p>
</td>
<td width="66">
<p>170</p>
</td>
<td width="66">
<p>170</p>
</td>
<td width="66">
<p>170</p>
</td>
<td width="66">
<p>170</p>
</td>
<td width="66">
<p>180</p>
</td>
</tr>
<tr>
<td width="99">
<p>Item 5</p>
<p>(4,50)</p>
</td>
<td width="53">
<p>20</p>
</td>
<td width="54">
<p>20</p>
</td>
<td width="54">
<p>20</p>
</td>
<td width="53">
<p>20</p>
</td>
<td width="53">
<p>70</p>
</td>
<td width="65">
<p>70</p>
</td>
<td width="65">
<p>70</p>
</td>
<td width="65">
<p>70</p>
</td>
<td width="66">
<p>140</p>
</td>
<td width="66">
<p>140</p>
</td>
<td width="66">
<p>140</p>
</td>
<td width="66">
<p>140</p>
</td>
<td width="66">
<p>190</p>
</td>
<td width="66">
<p>190</p>
</td>
<td width="66">
<p>190</p>
</td>
<td width="66">
<p>190</p>
</td>
<td width="66">
<p>190</p>
</td>
<td width="66">
<p>220</p>
</td>
<td width="66">
<p>220</p>
</td>
<td width="66">
<p>220</p>
</td>
<td width="66">
<p>220</p>
</td>
</tr>
<tr>
<td width="99">
<p>Item 6</p>
<p>(5,80)</p>
</td>
<td width="53">
<p>20</p>
</td>
<td width="54">
<p>20</p>
</td>
<td width="54">
<p>20</p>
</td>
<td width="53">
<p>20</p>
</td>
<td width="53">
<p>70</p>
</td>
<td width="65">
<p>100</p>
</td>
<td width="65">
<p>100</p>
</td>
<td width="65">
<p>100</p>
</td>
<td width="66">
<p>140</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>190</p>
</td>
<td width="66">
<p>220</p>
</td>
<td width="66">
<p>220</p>
</td>
<td width="66">
<p>220</p>
</td>
<td width="66">
<p>220</p>
</td>
<td width="66">
<p>270</p>
</td>
<td width="66">
<p>270</p>
</td>
<td width="66">
<p>270</p>
</td>
<td width="66">
<p>270</p>
</td>
</tr>
<tr>
<td width="99">
<p>Item 7</p>
<p>(2,10)</p>
</td>
<td width="53">
<p>20</p>
</td>
<td width="54">
<p>20</p>
</td>
<td width="54">
<p>30</p>
</td>
<td width="53">
<p>30</p>
</td>
<td width="53">
<p>70</p>
</td>
<td width="65">
<p>100</p>
</td>
<td width="65">
<p>100</p>
</td>
<td width="65">
<p>110</p>
</td>
<td width="66">
<p>140</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>150</p>
</td>
<td width="66">
<p>160</p>
</td>
<td width="66">
<p>190</p>
</td>
<td width="66">
<p>220</p>
</td>
<td width="66">
<p>220</p>
</td>
<td width="66">
<p>230</p>
</td>
<td width="66">
<p>230</p>
</td>
<td width="66">
<p>270</p>
</td>
<td width="66">
<p>270</p>
</td>
<td width="66">
<p>280</p>
</td>
<td width="66">
<p>280</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>How do we extract the info we need? We start with the last item; if it&rsquo;s marked as taken in the isItemTaken[,] matrix for the maximal capacity, we put the item in a list and reduce the capacity by its weight. On the next step, we&rsquo;ll check if the previous item is marked as taken for the remaining capacity and so on.</p>
<p>Finally, return the items taken as array:</p>
<p>&nbsp;</p>
<p>Since there are multiple items and each item has weight and price, taking input from the console won&rsquo;t be so easy. You either must tell the user how to enter the data or read it from a file. In any case, this will take time and is not crucial for the algorithm, so you may skip the "Remove the Hardcoded Values" step this time.</p>
<h1>Part II &ndash; Longest Common Subsequence</h1>
<p>Considering <strong>two sequences S<sub>1</sub> and S<sub>2</sub></strong>, the <strong>longest common subsequence</strong> is a sequence which is a subsequence of both S<sub>1</sub> and S<sub>2</sub>. For instance, if we have two strings (sequences of characters), "abc" and "adb", the LCS is "ab" &ndash; it is a subsequence of both sequences and it is the longest (there are two other subsequences &ndash; "a" and "b").</p>
<p>Examples:</p>
<table>
<tbody>
<tr>
<td width="640">
<p><strong>Input</strong></p>
</td>
<td width="748">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="640">
<p>abc</p>
<p>adb</p>
</td>
<td width="748">
<p>2</p>
</td>
</tr>
<tr>
<td width="640">
<p>ink some beer</p>
<p>drink se ber</p>
</td>
<td width="748">
<p>10</p>
</td>
</tr>
<tr>
<td width="640">
<p>tree</p>
<p>team</p>
</td>
<td width="748">
<p>2</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Setup</h2>
<p>For this problem, you&rsquo;ll be working with the <strong>Longest-Common-Subsequence</strong> and the <strong>Longest-Common-Subsequence.Tests </strong>projects.</p>
<p>Let&rsquo;s work with hardcoded values (strings) for now and create a method to find the LCS:</p>
<p>Your task will be to complete the FindLingestCommonSubsequence(string firstStr, string secondStr) method.</p>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LCS: Dynamic Programming Approach</h2>
<p>Just like the LIS problem, we can solve the LCS problem by <strong>solving sub-problems</strong> and keeping track of the solutions to the sub-problems (<strong>memoization</strong>). In the LIS problem we used an array, but here we&rsquo;ll be comparing two sequences, therefore, we&rsquo;ll need a matrix like the one below:</p>
<table>
<tbody>
<tr>
<td width="58">
<p>&nbsp;</p>
</td>
<td width="189">
<p>&nbsp;</p>
</td>
<td width="213">
<p>t</p>
</td>
<td width="243">
<p>e</p>
</td>
<td width="257">
<p>a</p>
</td>
<td width="280">
<p>m</p>
</td>
</tr>
<tr>
<td width="58">
<p>&nbsp;</p>
</td>
<td width="189">
<p>LCS("", "")</p>
</td>
<td width="213">
<p>LCS("", t)</p>
</td>
<td width="243">
<p>LCS("", te)</p>
</td>
<td width="257">
<p>LCS("", tea)</p>
</td>
<td width="280">
<p>LCS("", team)</p>
</td>
</tr>
<tr>
<td width="58">
<p>t</p>
</td>
<td width="189">
<p>LCS(t, "")</p>
</td>
<td width="213">
<p>LCS(t, t)</p>
</td>
<td width="243">
<p>LCS(t, te)</p>
</td>
<td width="257">
<p>LCS(t, tea)</p>
</td>
<td width="280">
<p>LCS(t, team)</p>
</td>
</tr>
<tr>
<td width="58">
<p>r</p>
</td>
<td width="189">
<p>LCS(tr, "")</p>
</td>
<td width="213">
<p>LCS(tr, t)</p>
</td>
<td width="243">
<p>LCS(tr, te)</p>
</td>
<td width="257">
<p>LCS(tr, tea)</p>
</td>
<td width="280">
<p>LCS(tr, team)</p>
</td>
</tr>
<tr>
<td width="58">
<p>e</p>
</td>
<td width="189">
<p>LCS(tre, "")</p>
</td>
<td width="213">
<p>LCS(tre, t)</p>
</td>
<td width="243">
<p>LCS(tre, te)</p>
</td>
<td width="257">
<p>LCS(tre, tea)</p>
</td>
<td width="280">
<p>LCS(tre, team)</p>
</td>
</tr>
<tr>
<td width="58">
<p>e</p>
</td>
<td width="189">
<p>LCS(tree, "")</p>
</td>
<td width="213">
<p>LCS(tree, t)</p>
</td>
<td width="243">
<p>LCS(tree, te)</p>
</td>
<td width="257">
<p>LCS(tree, tea)</p>
</td>
<td width="280">
<p>LCS(tree, team)</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>The rows will represent subsequences (substrings) of the first string ("tree"); the first row will represent a substring with length 0 (an empty string), the second row will represent a substring of length 1 ("t"), the third row will represent a substring of length 2 ("tr"), etc. The last row will represent a substring of length 4 which is the entire string "tree".</p>
<p>The columns will represent the substrings of the second string ("team"), again starting with an empty string and ending with the entire string.</p>
<p>In each cell, we&rsquo;ll enter the length of the LCS of the two substrings &ndash; the substring of the first string (the rows) and the second string (the columns). E.g., in the table above, cell (2, 2) will represent the LCS of "tr" and "te". Note that we assume that an empty string does not have anything in common with any other string, therefore row 0 and column 0 will be filled with zeros.</p>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Find the LCS for Every Combination of Substrings</h2>
<p>We know what to do &ndash; create a matrix of integers and calculate the LCS length for each cell. Let&rsquo;s begin.</p>
<p>The matrix should have 1 more row than the number of characters in the first string and 1 more column than the number of characters in the second string (the first row and column are the empty substrings). Therefore:</p>
<p>Now, we must iterate each cell of lcs[,] from top to bottom and from left to right and decide what number to put in that cell. Remember, at each step we already have the results from previous steps, so we can build on that. We have two distinct cases:</p>
<ul>
<li>The last character of the first substring is equal to the last character of the second substring</li>
</ul>
<p>This means that, compared to the cell which is to the left and up of the current one, the length of the current cell&rsquo;s LCS is greater by 1. Why? The cell to the left and up of the current one will hold the LCS of two substrings which are shorter by 1 than the current substrings; basically, the last character (which is the same) won&rsquo;t be present. Adding that same character to both substrings, we&rsquo;ll obtain the current cell and an LCS greater by 1.</p>
<ul>
<li>The last character of the first substring is different from the last character of the second substring</li>
</ul>
<p>We know the LCS of all substrings shorter than the current ones. The longest LCS so far should be one of two &ndash; the one directly above or the one directly to the left of the current cell. Adding a character to one of the substrings used to calculate these two LCSs doesn&rsquo;t have any effect, therefore, the current cell&rsquo;s LCS is the larger of the two.</p>
<p>Complete the if-statement following the logic above:</p>
<p>Once done, the matrix should be filled with the length of each LCS, like so:</p>
<table>
<tbody>
<tr>
<td width="58">
<p>&nbsp;</p>
</td>
<td width="136">
<p>&nbsp;</p>
</td>
<td colspan="2" width="265">
<p>t</p>
</td>
<td colspan="2" width="243">
<p>e</p>
</td>
<td colspan="2" width="257">
<p>a</p>
</td>
<td colspan="2" width="280">
<p>m</p>
</td>
<td width="54">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="58">
<p>&nbsp;</p>
</td>
<td colspan="2" width="241">
<p>0</p>
<p>LCS("", "") = ""</p>
</td>
<td colspan="2" width="213">
<p>0</p>
<p>LCS("", t) = ""</p>
</td>
<td colspan="2" width="243">
<p>0</p>
<p>LCS("", te) = ""</p>
</td>
<td colspan="2" width="257">
<p>0</p>
<p>LCS("", tea) = ""</p>
</td>
<td colspan="2" width="280">
<p>0</p>
<p>LCS("", team) = ""</p>
</td>
</tr>
<tr>
<td width="58">
<p>t</p>
</td>
<td colspan="2" width="241">
<p>0</p>
<p>LCS(t, "") = ""</p>
</td>
<td colspan="2" width="213">
<p>1</p>
<p>LCS(t, t) = t</p>
</td>
<td colspan="2" width="243">
<p>1</p>
<p>LCS(t, te) = t</p>
</td>
<td colspan="2" width="257">
<p>1</p>
<p>LCS(t, tea) = t</p>
</td>
<td colspan="2" width="280">
<p>1</p>
<p>LCS(t, team) = t</p>
</td>
</tr>
<tr>
<td width="58">
<p>r</p>
</td>
<td colspan="2" width="241">
<p>0</p>
<p>LCS(tr, "") = ""</p>
</td>
<td colspan="2" width="213">
<p>1</p>
<p>LCS(tr, t) = t</p>
</td>
<td colspan="2" width="243">
<p>1</p>
<p>LCS(tr, te) = t</p>
</td>
<td colspan="2" width="257">
<p>1</p>
<p>LCS(tr, tea) = t</p>
</td>
<td colspan="2" width="280">
<p>1</p>
<p>LCS(tr, team) = t</p>
</td>
</tr>
<tr>
<td width="58">
<p>e</p>
</td>
<td colspan="2" width="241">
<p>0</p>
<p>LCS(tre, "") = ""</p>
</td>
<td colspan="2" width="213">
<p>1</p>
<p>LCS(tre, t) = t</p>
</td>
<td colspan="2" width="243">
<p>2</p>
<p>LCS(tre, te) = te</p>
</td>
<td colspan="2" width="257">
<p>2</p>
<p>LCS(tre, tea) = te</p>
</td>
<td colspan="2" width="280">
<p>2</p>
<p>LCS(tre, team) = te</p>
</td>
</tr>
<tr>
<td width="58">
<p>e</p>
</td>
<td colspan="2" width="241">
<p>0</p>
<p>LCS(tree, "") = ""</p>
</td>
<td colspan="2" width="213">
<p>1</p>
<p>LCS(tree, t) = t</p>
</td>
<td colspan="2" width="243">
<p>2</p>
<p>LCS(tree, te) = te</p>
</td>
<td colspan="2" width="257">
<p>2</p>
<p>LCS(tree, tea) = te</p>
</td>
<td colspan="2" width="280">
<p>2</p>
<p>LCS(tree, team) = te</p>
</td>
</tr>
<tr>
<td width="44">&nbsp;</td>
<td width="91">&nbsp;</td>
<td width="49">&nbsp;</td>
<td width="107">&nbsp;</td>
<td width="32">&nbsp;</td>
<td width="113">&nbsp;</td>
<td width="27">&nbsp;</td>
<td width="113">&nbsp;</td>
<td width="28">&nbsp;</td>
<td width="130">&nbsp;</td>
<td width="13">&nbsp;</td>
</tr>
</tbody>
</table>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Recover the LCS by Iterating the lcs[,] Matrix</h2>
<p>Once the table is filled, all we need to do is recover what we need from it. Let&rsquo;s do this in a separate method, RetrieveLCS(string firstStr, string secondStr, int[,] lcs).</p>
<p>We iterate the matrix starting from the bottom-right corner until we reach row 0 or column 0. We&rsquo;ll fill the characters in a <strong>List&lt;char&gt;</strong>.</p>
<p>Again, we have two distinct cases:</p>
<ul>
<li>The last characters of the two substrings are the same &ndash; add the character to the list and move to the cell which is to the left and above the current one. The logic is the same as the one we used to fill the matrix.</li>
<li>The characters are different &ndash; we need to decide where to go next &ndash; up or left. We go to the cell which has the same LCS length as the current one (if both have the same length, it doesn&rsquo;t really matter).</li>
</ul>
<p>Finally, since we obtained all the characters in reversed order, we need to reverse the list and return it as a string. We can do the following:</p>
<h2>Problem 10. &nbsp;Remove the Hardcoded Values</h2>
<p>If the unit tests passed, your program is correct. You can modify the Main() method to receive the two strings from the console:</p>
<p>That&rsquo;s all!</p>
<p>&nbsp;</p>
<p>&nbsp;</p>