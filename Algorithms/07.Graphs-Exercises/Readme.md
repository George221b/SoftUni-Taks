<h1>Homework: Graph Algorithms</h1>
<p>This document defines the <strong>homework assignments</strong> for the <a href="https://softuni.bg/opencourses/algorithms">"Algortihms" course @ Software University</a>.</p>
<h2>1.&nbsp;&nbsp; Distance Between Vertices</h2>
<p>We are given a&nbsp;<strong>directed graph</strong>. We are given also a set of&nbsp;<strong>pairs of vertices</strong>. Find the&nbsp;<strong>shortest distance between each pair</strong>&nbsp;of vertices or&nbsp;<strong>-1</strong>&nbsp;if there is no path connecting them. &nbsp;</p>
<p>On the first line, you will get <strong>N</strong>, the number of vertices in the graph. On the second line, you will get P, the number of pairs between which to find the shortest distance.</p>
<p>On the next <strong>N</strong> lines will be the edges of the graph and on the next <strong>P</strong> lines, the pairs.</p>
<p>Examples</p>
<table>
<tbody>
<tr>
<td width="321">
<p><strong>Input</strong></p>
</td>
<td width="502">
<p><strong>Picture</strong></p>
</td>
<td width="356">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="321">
<p>2</p>
<p>2</p>
<p>1:2</p>
<p>2:</p>
<p>1-2</p>
<p>2-1</p>
</td>
<td width="502">&nbsp;</td>
<td width="356">
<p>{1, 2} -&gt; 1</p>
<p>{2, 1} -&gt; -1</p>
</td>
</tr>
<tr>
<td width="321">
<p>8</p>
<p>4</p>
<p>1:4</p>
<p>2:4</p>
<p>3:4 5</p>
<p>4:6</p>
<p>5:3 7 8</p>
<p>6:</p>
<p>7:8</p>
<p>8:</p>
<p>1-6</p>
<p>1-5</p>
<p>5-6</p>
<p>5-8</p>
</td>
<td width="502">&nbsp;</td>
<td width="356">
<p>{1, 6} -&gt; 2</p>
<p>{1, 5} -&gt; -1</p>
<p>{5, 6} -&gt; 3</p>
<p>{5, 8} -&gt; 1</p>
</td>
</tr>
<tr>
<td width="321">
<p>9</p>
<p>8</p>
<p>11:4</p>
<p>4:12 1</p>
<p>1:12 21 7</p>
<p>7:21</p>
<p>12:4 19</p>
<p>19:1 21</p>
<p>21:14 31</p>
<p>14:14</p>
<p>31:</p>
<p>11-7</p>
<p>11-21</p>
<p>21-4</p>
<p>19-14</p>
<p>1-4</p>
<p>1-11</p>
<p>31-21</p>
<p>11-14</p>
</td>
<td width="502">&nbsp;</td>
<td width="356">
<p>{11, 7} -&gt; 3</p>
<p>{11, 21} -&gt; 3</p>
<p>{21, 4} -&gt; -1</p>
<p>{19, 14} -&gt; 2</p>
<p>{1, 4} -&gt; 2</p>
<p>{1, 11} -&gt; -1</p>
<p>{31, 21} -&gt; -1</p>
<p>{11, 14} -&gt; 4</p>
</td>
</tr>
</tbody>
</table>
<p>Hint</p>
<p>For each pair use&nbsp;<strong>BFS</strong>&nbsp;to find all paths from the source to the destination vertex.</p>
<h2>2.&nbsp;&nbsp; Areas in Matrix</h2>
<p>We are given a&nbsp;matrix of letters&nbsp;of size N * M. Two cells are&nbsp;neighbor&nbsp;if they share a common wall.&nbsp;Write a program to find the&nbsp;connected areas&nbsp;of neighbor cells holding the same letter. Display the&nbsp;<strong>total number of areas</strong>&nbsp;and the&nbsp;number of <strong>areas for each alphabetical letter</strong> (ordered by alphabetical order).</p>
<p>On the <strong>first line</strong> is given the <strong>number of rows</strong>.</p>
<p>Examples</p>
<table>
<tbody>
<tr>
<td width="313">
<p><strong>Input</strong></p>
</td>
<td width="511">
<p><strong>Picture</strong></p>
</td>
<td width="335">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="313">
<p>6</p>
<p>aacccaac</p>
<p>baaaaccc</p>
<p>baabaccc</p>
<p>bbdaaccc</p>
<p>ccdccccc</p>
<p>ccdccccc</p>
</td>
<td width="511">&nbsp;</td>
<td width="335">
<p>Areas: 8</p>
<p>Letter 'a' -&gt; 2</p>
<p>Letter 'b' -&gt; 2</p>
<p>Letter 'c' -&gt; 3</p>
<p>Letter 'd' -&gt; 1</p>
</td>
</tr>
<tr>
<td width="313">
<p>3</p>
<p>aaa</p>
<p>aaa</p>
<p>aaa</p>
</td>
<td width="511">&nbsp;</td>
<td width="335">
<p>Areas: 1</p>
<p>Letter 'a' -&gt; 1</p>
</td>
</tr>
<tr>
<td width="313">
<p>5</p>
<p>asssaadas</p>
<p>adsdasdad</p>
<p>sdsdadsas</p>
<p>sdasdsdsa</p>
<p>ssssasddd</p>
</td>
<td width="511">&nbsp;</td>
<td width="335">
<p>Areas: 21</p>
<p>Letter 'a' -&gt; 6</p>
<p>Letter 'd' -&gt; 7</p>
<p>Letter 's' -&gt; 8</p>
</td>
</tr>
</tbody>
</table>
<h3>Hint</h3>
<p>Initially mark all cells as <strong>unvisited</strong>. Start a&nbsp;<strong>recursive DFS traversal</strong>&nbsp;(or BFS) from each unvisited cell and mark all reached cells as visited. Each DFS traversal will find one of the <strong>connected areas</strong>.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>3.&nbsp;&nbsp; Cycles in a Graph</h2>
<p>Write a program to check whether an&nbsp;undirected graph&nbsp;is&nbsp;<strong>acyclic</strong>&nbsp;or holds any&nbsp;cycles.</p>
<p>Examples</p>
<table>
<tbody>
<tr>
<td width="119">
<p><strong>Input</strong></p>
</td>
<td width="690">
<p><strong>Picture</strong></p>
</td>
<td width="241">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="119">
<p>C&ndash;G</p>
</td>
<td width="690">&nbsp;</td>
<td width="241">
<p>Acyclic: Yes</p>
</td>
</tr>
<tr>
<td width="119">
<p>A&ndash;F</p>
<p>F&ndash;D</p>
<p>D&ndash;A</p>
<p>&nbsp;</p>
</td>
<td width="690">&nbsp;</td>
<td width="241">
<p>Acyclic: No</p>
</td>
</tr>
<tr>
<td width="119">
<p>E&ndash;Q</p>
<p>Q&ndash;P</p>
<p>P&ndash;B</p>
</td>
<td width="690">&nbsp;</td>
<td width="241">
<p>Acyclic: Yes</p>
</td>
</tr>
<tr>
<td width="119">
<p>K&ndash;J</p>
<p>J&ndash;N</p>
<p>N&ndash;L</p>
<p>N&ndash;M</p>
<p>M&ndash;I</p>
</td>
<td width="690">&nbsp;</td>
<td width="241">
<p>Acyclic: Yes</p>
</td>
</tr>
<tr>
<td width="119">
<p>K&ndash;X</p>
<p>X&ndash;Y</p>
<p>X&ndash;N</p>
<p>N&ndash;J</p>
<p>M&ndash;N</p>
<p>A&ndash;Z</p>
<p>B&ndash;P</p>
<p>I&ndash;F</p>
<p>A&ndash;Y</p>
<p>Y&ndash;L</p>
<p>M&ndash;I</p>
<p>F&ndash;P</p>
<p>Z&ndash;E</p>
<p>P&ndash;E</p>
</td>
<td width="690">&nbsp;</td>
<td width="241">
<p>Acyclic: No</p>
</td>
</tr>
</tbody>
</table>
<p>Hint</p>
<p>Modify the Topological Sorting algorithm (source removal or DFS-based).</p>
<h2>4.&nbsp;&nbsp; Salaries</h2>
<p>You can test your solution to the problem in the Judge system <a href="https://judge.softuni.bg/Contests/Practice/Index/114#4">here</a>.</p>
<p>We have a <strong>hierarchy</strong>&nbsp;between the employees&nbsp;in a company. Employees can have one or several direct managers. People who <strong>manage nobody</strong> are called&nbsp;<strong>regular employees</strong>&nbsp;and their salaries are&nbsp;<strong>1</strong>. People who manage at least one employee are called&nbsp;<strong>managers</strong>. Each manager takes a <strong>salary</strong> which is equal to the <strong>sum of the salaries of their directly managed employees</strong>. Managers cannot manage directly or indirectly (transitively) themselves. Some employees might have no manager (like the big boss). See a sample hierarchy in a company along with the salaries computed following the above described rule:</p>
<p>In the above example the employees 0 and 3 are regular employees and take salary 1. All others are managers and take the sum of the salaries of their directly managed employees. For example, manager 1 takes salary 3 + 2 + 1 = 6 (sum of the salaries of employees 2, 5 and 0). In the above example employees 4 and 1 have no manager.</p>
<p>If we have <strong>N</strong> employees, they will be indexed from 0 to N &ndash; 1. For each employee, you&rsquo;ll be given a string with N symbols. The symbol at a given index <strong>i</strong>, either <strong>'Y' or 'N'</strong>, shows whether the current employee is a direct manager of employee <strong>i</strong>.</p>
<p><strong>Hint</strong>: find the node with no parent and start a&nbsp;<strong>DFS traversal</strong>&nbsp;from it to calculate the salaries on the tree recursively.</p>
<h3>Input</h3>
<ul>
<li>The input data should be read from the console.</li>
<li>On the first line you&rsquo;ll be given an integer N.</li>
<li>On the next N lines you&rsquo;ll be given strings with N symbols (either 'Y' or 'N').</li>
<li>The input data will always be valid and in the format described. There is no need to check it explicitly.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output should be printed on the console. It should consist of one line.</li>
<li>On the only output line print the sum of the salaries of all employees.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>N will be an integer in the range [1 &hellip; 50].</li>
<li>For each i-th line, the i-th symbol will be 'N'.</li>
<li>If employee A is the manager of employee B, B will not be a manager of A.</li>
<li>Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.</li>
</ul>
<h3>Examples</h3>
<table width="1336">
<tbody>
<tr>
<td width="142">
<p><strong>Input</strong></p>
</td>
<td width="120">
<p><strong>Output</strong></p>
</td>
<td width="1073">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="142">
<p>1</p>
<p>N</p>
</td>
<td width="120">
<p>1</p>
</td>
<td width="1073">
<p>Only 1 employee with salary 1.</p>
</td>
</tr>
<tr>
<td width="142">
<p>4</p>
<p>NNYN</p>
<p>NNYN</p>
<p>NNNN</p>
<p>NYYN</p>
</td>
<td width="120">
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>5</p>
</td>
<td width="1073">
<p>We have 4 employees. 0, 1, and 3 are managers of 2. 3 is also a manager of 1. Therefore:</p>
<p>salary(2) = 1</p>
<p>salary(0) = salary(2) = 1</p>
<p>salary(1) = salary(2) = 1</p>
<p>salary(3) = salary(2) + salary(1) = 2</p>
</td>
</tr>
<tr>
<td width="142">
<p>6</p>
<p>NNNNNN</p>
<p>YNYNNY</p>
<p>YNNNNY</p>
<p>NNNNNN</p>
<p>YNYNNN</p>
<p>YNNYNN</p>
</td>
<td width="120">
<p>17</p>
</td>
<td width="1073">&nbsp;</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>5.&nbsp;&nbsp; *&nbsp;Break Cycles</h2>
<p>You are given&nbsp;<strong>undirected multi-graph</strong>. Remove a minimal number of edges to&nbsp;<strong>make the graph acyclic</strong>&nbsp;(to break all cycles). As a result, print the number of edges removed and the removed edges. If several edges can be removed to break a certain cycle, remove the smallest of them in alphabetical order (smallest start vertex in alphabetical order and smallest end vertex in alphabetical order).</p>
<p>Examples</p>
<table width="1398">
<tbody>
<tr>
<td width="285">
<p><strong>Input</strong></p>
</td>
<td width="394">
<p><strong>Picture</strong></p>
</td>
<td width="328">
<p><strong>Output</strong></p>
</td>
<td width="391">
<p><strong>Picture After Removal</strong></p>
</td>
</tr>
<tr>
<td width="285">
<p>1 -&gt; 2 5 4</p>
<p>2 -&gt; 1 3</p>
<p>3 -&gt; 2 5</p>
<p>4 -&gt; 1</p>
<p>5 -&gt; 1 3</p>
<p>6 -&gt; 7 8</p>
<p>7 -&gt; 6 8</p>
<p>8 -&gt; 6 7</p>
</td>
<td width="394">&nbsp;</td>
<td width="328">
<p>Edges to remove: 2</p>
<p>1 - 2</p>
<p>6 - 7</p>
</td>
<td width="391">&nbsp;</td>
</tr>
<tr>
<td width="285">
<p>K -&gt; X J</p>
<p>J -&gt; K N</p>
<p>N -&gt; J X L M</p>
<p>X -&gt; K N Y</p>
<p>M -&gt; N I</p>
<p>Y -&gt; X L</p>
<p>L -&gt; N I Y</p>
<p>I -&gt; M L</p>
<p>A -&gt; Z Z Z</p>
<p>Z -&gt; A A A</p>
<p>F -&gt; E B P</p>
<p>E -&gt; F P</p>
<p>P -&gt; B F E</p>
<p>B -&gt; F P</p>
</td>
<td width="394">&nbsp;</td>
<td width="328">
<p>Edgeds to remove: 7</p>
<p>A - Z</p>
<p>A - Z</p>
<p>B - F</p>
<p>E - F</p>
<p>I - L</p>
<p>J - K</p>
<p>L - N</p>
</td>
<td width="391">&nbsp;</td>
</tr>
</tbody>
</table>
<h3>Hint</h3>
<ul>
<li>Enumerate edges {<strong>s</strong>, <strong>e</strong>} in alphabetical order. For each edge {<strong>s</strong>, <strong>e</strong>} check whether it closes a cycle. If yes - remove it.
<ul>
<li>To check whether an edge {<strong>s</strong>, <strong>e</strong>} closes a cycle, temporarily remove the edge {s, e} and then try to find a path from <strong>s</strong> to <strong>e</strong> using DFS or BFS.</li>
</ul>
</li>
</ul>
<p>&nbsp;</p>