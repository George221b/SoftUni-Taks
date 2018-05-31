<h1>Homework: Greedy Algorithms</h1>
<p>This document defines the <strong>homework assignments</strong> for the <a href="https://softuni.bg/opencourses/algorithms">"Algortihms" course @ Software University</a>. Submit your solutions to the automated <a href="https://judge.softuni.bg/Contests/702/Greedy-Algorithms-Exercise">Judge</a> system.</p>
<h2>1.&nbsp;&nbsp; Fractional Knapsack Problem</h2>
<p>A modification of the famous knapsack problem is the so-called <a href="https://en.wikipedia.org/wiki/Continuous_knapsack_problem">continuous (or fractional) knapsack problem</a>.</p>
<p>We have N items, each with a certain <strong>weight</strong> and <strong>price</strong>. The knapsack has a <strong>maximum capacity</strong>, so we need to choose what to take in order to <strong>maximize the value (price)</strong> of the items in it.</p>
<p>Unlike the classical version of the problem where an object should either be taken in its entirety or not at all, in this version <strong>we can take a fraction of each item</strong>. For example, such items may be liquids or powders; unlike solid objects which (presumably) we cannot split, we&rsquo;ll assume that all items under consideration can be divided in any proportion. Therefore, the weight can be thought as the maximum quantity Q of an item we are allowed to take &ndash; we can take any amount in the range [0 &hellip; Q]. Note that in this version of the problem the knapsack will always be filled completely (if the total quantity of items is greater than its capacity).</p>
<p>Items will be given on separate lines in format <strong>price -&gt; weight</strong>. Round all numbers to two digits after the decimal separator.</p>
<h3>Examples</h3>
<table width="1110">
<tbody>
<tr>
<td width="232">
<p><strong>Input</strong></p>
</td>
<td width="877">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="232">
<p>Capacity: 16</p>
<p>Items: 3</p>
<p>25 -&gt; 10</p>
<p>12 -&gt; 8</p>
<p>16 -&gt; 8</p>
</td>
<td width="877">
<p>Take 100% of item with price 25.00 and weight 10.00</p>
<p>Take 75.00% of item with price 16.00 and weight 8.00</p>
<p>Total price: 37.00</p>
</td>
</tr>
<tr>
<td width="232">
<p>Capacity: 13</p>
<p>Items: 2</p>
<p>13 -&gt; 7</p>
<p>15 -&gt; 7</p>
</td>
<td width="877">
<p>Take 100% of item with price 15.00 and weight 7.00</p>
<p>Take 85.71% of item with price 13.00 and weight 7.00</p>
<p>Total price: 26.14</p>
</td>
</tr>
<tr>
<td width="232">
<p>Capacity: 22</p>
<p>Items: 4</p>
<p>50 -&gt; 25</p>
<p>34 -&gt; 25</p>
<p>41 -&gt; 25</p>
<p>3 -&gt; 25</p>
</td>
<td width="877">
<p>Take 88.00% of item with price 50.00 and weight 25.00</p>
<p>Total price: 44.00</p>
</td>
</tr>
<tr>
<td width="232">
<p>Capacity: 134</p>
<p>Items: 9</p>
<p>12 -&gt; 14</p>
<p>45 -&gt; 54</p>
<p>98 -&gt; 78</p>
<p>21 -&gt; 51</p>
<p>64 -&gt; 11</p>
<p>90 -&gt; 117</p>
<p>33 -&gt; 17</p>
<p>64 -&gt; 23</p>
<p>7 -&gt; 3</p>
</td>
<td width="877">
<p>Take 100% of item with price 64.00 and weight 11.00</p>
<p>Take 100% of item with price 64.00 and weight 23.00</p>
<p>Take 100% of item with price 7.00 and weight 3.00</p>
<p>Take 100% of item with price 33.00 and weight 17.00</p>
<p>Take 100% of item with price 98.00 and weight 78.00</p>
<p>Take 14.29% of item with price 12.00 and weight 14.00</p>
<p>Total price: 267.71</p>
</td>
</tr>
<tr>
<td width="232">
<p>Capacity: 10</p>
<p>Items: 1</p>
<p>25 -&gt; 5</p>
</td>
<td width="877">
<p>Take 100% of item with price 25 and weight 5</p>
<p>Total price: 25.00</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Use a greedy algorithm: take the best item (max price / weight) as much as possible, then the next best item, etc.</p>
<h2>2.&nbsp;&nbsp; Processor Scheduling</h2>
<p>We are given a processor capable of performing only <strong>one task at a time</strong> and <strong>N</strong> tasks. Each task has two properties associated with it &ndash; <strong>value</strong> <strong>v</strong> of completing the task and a <strong>deadline</strong> <strong>d</strong>. Each task takes exactly one unit of time to complete and should be completed at or before its deadline. E.g., if we have a task with deadline 2, we can complete it either at step 1 or step 2, but not afterwards. Given a set of tasks numbered from 1 to N, find a schedule which will <strong>maximize the total value</strong> of the tasks performed.</p>
<p>Consider the following scenario:</p>
<table>
<tbody>
<tr>
<td width="198">
<p>Task number</p>
</td>
<td width="73">
<p>1</p>
</td>
<td width="73">
<p>2</p>
</td>
<td width="73">
<p>3</p>
</td>
<td width="73">
<p>4</p>
</td>
<td width="73">
<p>5</p>
</td>
</tr>
<tr>
<td width="198">
<p>Value</p>
</td>
<td width="73">
<p>40</p>
</td>
<td width="73">
<p>30</p>
</td>
<td width="73">
<p>15</p>
</td>
<td width="73">
<p>20</p>
</td>
<td width="73">
<p>50</p>
</td>
</tr>
<tr>
<td width="198">
<p>Deadline</p>
</td>
<td width="73">
<p>1</p>
</td>
<td width="73">
<p>2</p>
</td>
<td width="73">
<p>1</p>
</td>
<td width="73">
<p>1</p>
</td>
<td width="73">
<p>2</p>
</td>
</tr>
</tbody>
</table>
<p>With a maximum of 2 steps (largest deadline is 2) we can complete at most two tasks. Performing one of the tasks that has a deadline 2 on the first step leaves us with no choice for the second step, but to take the other task with deadline 2 (tasks with deadline 1 can no longer be performed). Therefore, 2 -&gt; 5, or 5 -&gt; 2 will produce a total value of 30 + 50 = 80.</p>
<p>It is obvious from the table above that the optimal solution is 1 -&gt; 5 which produces total value of 40 + 50 = 90.</p>
<p>Since tasks can be performed in different order, when printing the output, order the tasks based on their deadline in increasing order and then by value in decreasing order.</p>
<h3>Examples</h3>
<table width="884">
<tbody>
<tr>
<td width="297">
<p><strong>Input</strong></p>
</td>
<td width="587">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="297">
<p>Tasks: 5</p>
<p>40 - 1</p>
<p>30 - 2</p>
<p>15 - 1</p>
<p>20 - 1</p>
<p>50 - 2</p>
</td>
<td width="587">
<p>Optimal schedule:&nbsp; 1 -&gt; 5</p>
<p>Total value: 90</p>
</td>
</tr>
<tr>
<td width="297">
<p>Tasks: 3</p>
<p>25 - 1</p>
<p>14 - 1</p>
<p>43 - 1</p>
</td>
<td width="587">
<p>Optimal schedule: 3</p>
<p>Total value: 43</p>
</td>
</tr>
<tr>
<td width="297">
<p>Tasks: 6</p>
<p>5 - 3</p>
<p>6 - 4</p>
<p>2 - 1</p>
<p>3 - 4</p>
<p>8 - 2</p>
<p>4 - 3</p>
</td>
<td width="587">
<p>Optimal schedule: 5 -&gt; 1 -&gt; 6 -&gt; 2</p>
<p>Total value: 23</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>At each step, take the task with highest value. Make sure that when adding the task to the result, all tasks that were selected can be completed.</p>
<h2>3.&nbsp;&nbsp; Knight&rsquo;s Tour</h2>
<p>Given a board of size <strong>NxN</strong> (a standard square matrix), a chess knight can perform a tour of the board, <strong>visiting each cell only once</strong>. The knight moves according to the rules of chess (in an L-shaped pattern) and starts from the upper-left corner. Write a program which finds and prints the path the knight needs to take in order to visit all cells. From the input, you receive just the board size <strong>N</strong> (N &gt; 4).</p>
<p>On the output, print the board where each cell&rsquo;s value is the number of the step which led to it, e.g. cell (0, 0) will be 1, the first step, the next visited cell (0, 2) will have value 2, etc. In order to format the output, assume NxN &lt; 1000 &ndash; no cell&rsquo;s value will be more than 3 digits (you can pad the values with spaces with the string.PadLeft() method).</p>
<h3>Examples</h3>
<table width="942">
<tbody>
<tr>
<td width="129">
<p><strong>Input</strong></p>
</td>
<td width="813">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="129">
<p>5</p>
</td>
<td width="813">
<p>&nbsp;&nbsp; 1&nbsp; 12&nbsp; 25&nbsp; 18&nbsp;&nbsp; 3</p>
<p>&nbsp; 22&nbsp; 17&nbsp;&nbsp; 2&nbsp; 13&nbsp; 24</p>
<p>&nbsp; 11&nbsp;&nbsp; 8&nbsp; 23&nbsp;&nbsp; 4&nbsp; 19</p>
<p>&nbsp; 16&nbsp; 21&nbsp;&nbsp; 6&nbsp;&nbsp; 9&nbsp; 14</p>
<p>&nbsp;&nbsp; 7&nbsp; 10&nbsp; 15&nbsp; 20&nbsp;&nbsp; 5</p>
</td>
</tr>
<tr>
<td width="129">
<p>6</p>
</td>
<td width="813">
<p>&nbsp;&nbsp; 1&nbsp; 32&nbsp;&nbsp; 9&nbsp; 18&nbsp;&nbsp; 3&nbsp; 34</p>
<p>&nbsp; 10&nbsp; 19&nbsp;&nbsp; 2&nbsp; 33&nbsp; 26&nbsp; 17</p>
<p>&nbsp; 31&nbsp;&nbsp; 8&nbsp; 25&nbsp; 16&nbsp; 35&nbsp;&nbsp; 4</p>
<p>&nbsp; 20&nbsp; 11&nbsp; 36&nbsp; 27&nbsp; 24&nbsp; 15</p>
<p>&nbsp;&nbsp; 7&nbsp; 30&nbsp; 13&nbsp; 22&nbsp;&nbsp; 5&nbsp; 28</p>
<p>&nbsp; 12&nbsp; 21&nbsp;&nbsp; 6&nbsp; 29&nbsp; 14&nbsp; 23</p>
</td>
</tr>
<tr>
<td width="129">
<p>12</p>
</td>
<td width="813">
<p>&nbsp;&nbsp; 1&nbsp; 24&nbsp; 61&nbsp; 96&nbsp;&nbsp; 3&nbsp; 26&nbsp; 91 110&nbsp;&nbsp; 5&nbsp; 28&nbsp; 31 112</p>
<p>&nbsp; 62&nbsp; 95&nbsp;&nbsp; 2&nbsp; 25&nbsp; 92 141&nbsp;&nbsp; 4&nbsp; 27 114 111&nbsp;&nbsp; 6&nbsp; 29</p>
<p>&nbsp; 23&nbsp; 60&nbsp; 93 144&nbsp; 97&nbsp; 90 135 142 109&nbsp; 30 113&nbsp; 32</p>
<p>&nbsp; 94&nbsp; 63&nbsp; 98&nbsp; 89 140 143 130 115 136 119 108&nbsp;&nbsp; 7</p>
<p>&nbsp; 59&nbsp; 22 139 100 129 134 137 126 107 116&nbsp; 33 118</p>
<p>&nbsp; 64&nbsp; 99&nbsp; 88 133 138 127 106 131 120 125&nbsp;&nbsp; 8&nbsp; 81</p>
<p>&nbsp; 21&nbsp; 58&nbsp; 65 128 101 132 121 124 105&nbsp; 82 117&nbsp; 34</p>
<p>&nbsp; 46&nbsp; 55 102&nbsp; 87&nbsp; 66&nbsp; 77 104&nbsp; 83 122&nbsp; 75&nbsp; 80&nbsp;&nbsp; 9</p>
<p>&nbsp; 57&nbsp; 20&nbsp; 47&nbsp; 54 103&nbsp; 86 123&nbsp; 76&nbsp; 79&nbsp; 84&nbsp; 35&nbsp; 74</p>
<p>&nbsp; 42&nbsp; 45&nbsp; 56&nbsp; 67&nbsp; 50&nbsp; 53&nbsp; 78&nbsp; 85&nbsp; 70&nbsp; 73&nbsp; 10&nbsp; 13</p>
<p>&nbsp; 19&nbsp; 48&nbsp; 43&nbsp; 40&nbsp; 17&nbsp; 68&nbsp; 51&nbsp; 38&nbsp; 15&nbsp; 12&nbsp; 71&nbsp; 36</p>
<p>&nbsp; 44&nbsp; 41&nbsp; 18&nbsp; 49&nbsp; 52&nbsp; 39&nbsp; 16&nbsp; 69&nbsp; 72&nbsp; 37&nbsp; 14&nbsp; 11</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Use <a href="https://en.wikipedia.org/wiki/Knight%27s_tour#Warnsdorf.27s_rule">Warnsdorff's rule</a> to decide which cell the knight should visit next.</p>
<h2>4.&nbsp;&nbsp; Best Lectures Schedule</h2>
<p>A long time ago in a neighborhood far, far away SoftUni used to have just one lecture hall. Let&rsquo;s have a list of lectures, each having a <strong>start time s</strong> and a <strong>finish time f</strong> (<strong>s</strong> and <strong>f</strong> will be positive integers). Obviously, only one lecture can be presented at a time, they cannot overlap. Write a program that maximizes the number of lectures presented.</p>
<p>Lectures will be given in format <strong>name:</strong> <strong>start &ndash; finish</strong>. Assume the name will contain only word characters (letters, digits and '_').</p>
<h3>Examples</h3>
<table width="981">
<tbody>
<tr>
<td width="490">
<p><strong>Input</strong></p>
</td>
<td width="490">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="490">
<p>Lectures: 4</p>
<p>Java: 1 - 7</p>
<p>OOP: 3 - 13</p>
<p>C_Programming: 5 - 9</p>
<p>Advanced_JavaScript: 10 - 14</p>
</td>
<td width="490">
<p>Lectures (2):</p>
<p>1-7 -&gt; Java</p>
<p>10-14 -&gt; Advanced_JavaScript</p>
</td>
</tr>
<tr>
<td width="490">
<p>Lectures: 3</p>
<p>Programming_Basics: 3 - 5</p>
<p>PHP: 2 - 4</p>
<p>Photoshop: 1 - 6</p>
</td>
<td width="490">
<p>Lectures (1):</p>
<p>2-4 -&gt; PHP</p>
</td>
</tr>
<tr>
<td width="490">
<p>Lectures: 7</p>
<p>Advanced_CSharp: 3 - 8</p>
<p>High_Quality_Code: 7 - 10</p>
<p>Databases: 5 - 12</p>
<p>ASP_NET: 9 - 14</p>
<p>Angular_JS: 13 - 15</p>
<p>Algorithms: 15 - 19</p>
<p>Programming_Basics: 17 - 20</p>
</td>
<td width="490">
<p>Lectures (3):</p>
<p>3-8 -&gt; Advanced_CSharp</p>
<p>9-14 -&gt; ASP_NET</p>
<p>15-19 -&gt; Algorithms</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Use the finish time to decide which lecture should be chosen at each step. After a lecture is chosen, remove all others that overlap with it.</p>
<h2>5.&nbsp;&nbsp; Egyptian Fractions</h2>
<p>In mathematics, a fraction is the rational number <strong>p/q</strong> where <strong>p</strong> and <strong>q</strong> are integers. An Egyptian fraction is a sum of fractions, each with <strong>numerator 1</strong> where <strong>all denominators are different</strong>, e.g. 1/2 + 1/3 + 1/16 is an Egyptian fraction, but 1/3 + 1/3 + 1/5 is not (repeated denominator 3).</p>
<p>Every positive fraction (q != 0, p &lt; q) can be represented by an Egyptian fraction, for instance, 43/48 = 1/2 + 1/3 + 1/16. Given <strong>p</strong> and <strong>q</strong>, write a program to represent the fraction <strong>p/q</strong> as an Egyptian fraction.</p>
<h3>Examples</h3>
<table width="1101">
<tbody>
<tr>
<td width="297">
<p><strong>Input</strong></p>
</td>
<td width="804">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="297">
<p>43/48</p>
</td>
<td width="804">
<p>43/48 = 1/2 + 1/3 + 1/16</p>
</td>
</tr>
<tr>
<td width="297">
<p>3/7</p>
</td>
<td width="804">
<p>3/7 = 1/3 + 1/11 + 1/231</p>
</td>
</tr>
<tr>
<td width="297">
<p>23/46</p>
</td>
<td width="804">
<p>23/46 = 1/2</p>
</td>
</tr>
<tr>
<td width="297">
<p>22/7</p>
</td>
<td width="804">
<p>Error (fraction is equal to or greater than 1)</p>
</td>
</tr>
<tr>
<td width="297">
<p>134/3151</p>
</td>
<td width="804">
<p>134/3151 = 1/24 + 1/1164 + 1/2445176</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Note</strong>: There may be more than one correct solution, e.g. 3/7 = 1/4 + 1/8 + 1/19 + 1/1064. If you follow the greedy algorithm logic, you should get the solutions given in the input/output examples.</p>
<h3>Hints</h3>
<p>You can complete the expression by starting with the biggest fraction with numerator 1 which added to the expression keeps it smaller than or equal to the target fraction. The biggest fraction is the one with smallest denominator &ndash; 1/2. Increase the denominator until you&rsquo;ve found a solution.</p>
<p>&nbsp;</p>