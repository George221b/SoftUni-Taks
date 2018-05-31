<h1>Homework: Advanced Graph Algorithms - Part II</h1>
<p>This document defines the <strong>homework assignments</strong> for the <a href="https://softuni.bg/opencourses/algorithms">"Algortihms" course @ Software University</a>.</p>
<h2>1. * Maximum Tasks Assignment</h2>
<p>We have <strong>L</strong> persons and <strong>R</strong> tasks. <strong>Each person can complete at most one task</strong>. <strong>One task can be completed by at most one person.</strong> We have a table that shows which persons are able to complete which tasks. Find the <strong>maximum assignment</strong> that assigns tasks to persons in order to complete a maximum number of tasks.</p>
<p>Example: we have 3 people {A, B, C} and 3 tasks {1, 2, 3}. We have the following table that shows whether a person can complete a certain job.</p>
<table>
<tbody>
<tr>
<td width="58">
<p>&nbsp;</p>
</td>
<td width="60">
<p>A</p>
</td>
<td width="59">
<p>B</p>
</td>
<td width="59">
<p>C</p>
</td>
</tr>
<tr>
<td width="58">
<p>1</p>
</td>
<td width="60">
<p>?</p>
</td>
<td width="59">
<p>&nbsp;</p>
</td>
<td width="59">
<p>?</p>
</td>
</tr>
<tr>
<td width="58">
<p>2</p>
</td>
<td width="60">
<p>&nbsp;</p>
</td>
<td width="59">
<p>?</p>
</td>
<td width="59">
<p>?</p>
</td>
</tr>
<tr>
<td width="58">
<p>3</p>
</td>
<td width="60">
<p>?</p>
</td>
<td width="59">
<p>?</p>
</td>
<td width="59">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>In the above table, we should make the <strong>maximal assignment</strong>: select from each row and each column at most one checkmark value. A sample solution is shown below:</p>
<table>
<tbody>
<tr>
<td width="58">
<p>&nbsp;</p>
</td>
<td width="60">
<p>A</p>
</td>
<td width="59">
<p>B</p>
</td>
<td width="59">
<p>C</p>
</td>
</tr>
<tr>
<td width="58">
<p>1</p>
</td>
<td width="60">
<p><strong>?</strong></p>
</td>
<td width="59">
<p>&nbsp;</p>
</td>
<td width="59">
<p>?</p>
</td>
</tr>
<tr>
<td width="58">
<p>2</p>
</td>
<td width="60">
<p>&nbsp;</p>
</td>
<td width="59">
<p>?</p>
</td>
<td width="59">
<p><strong>?</strong></p>
</td>
</tr>
<tr>
<td width="58">
<p>3</p>
</td>
<td width="60">
<p>?</p>
</td>
<td width="59">
<p><strong>?</strong></p>
</td>
<td width="59">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<p>Assume persons will be marked by letters of the English alphabet and tasks by numbers starting from 1</p>
<table width="1179">
<tbody>
<tr>
<td width="201">
<p><strong>Input</strong></p>
</td>
<td width="216">
<p><strong>Output</strong></p>
</td>
<td width="320">
<p><strong>Table</strong></p>
</td>
<td width="442">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="201">
<p>Persons: 3</p>
<p>Tasks: 3</p>
<p>YNY</p>
<p>NYY</p>
<p>YYN</p>
</td>
<td width="216">
<p>A-1</p>
<p>B-3</p>
<p>C-2</p>
</td>
<td width="320">
<table>
<tbody>
<tr>
<td width="58">
<p>&nbsp;</p>
</td>
<td width="60">
<p>A</p>
</td>
<td width="59">
<p>B</p>
</td>
<td width="59">
<p>C</p>
</td>
</tr>
<tr>
<td width="58">
<p>1</p>
</td>
<td width="60">
<p><strong>?</strong></p>
</td>
<td width="59">
<p>&nbsp;</p>
</td>
<td width="59">
<p>?</p>
</td>
</tr>
<tr>
<td width="58">
<p>2</p>
</td>
<td width="60">
<p>&nbsp;</p>
</td>
<td width="59">
<p>?</p>
</td>
<td width="59">
<p><strong>?</strong></p>
</td>
</tr>
<tr>
<td width="58">
<p>3</p>
</td>
<td width="60">
<p>?</p>
</td>
<td width="59">
<p><strong>?</strong></p>
</td>
<td width="59">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
</td>
<td width="442">
<p>Another correct solution:</p>
<p>A-3</p>
<p>B-2</p>
<p>C-1</p>
</td>
</tr>
<tr>
<td width="201">
<p>Persons: 4</p>
<p>Tasks: 4</p>
<p>YNYN</p>
<p>NYYN</p>
<p>YNYY</p>
<p>NNNY</p>
</td>
<td width="216">
<p>A-1</p>
<p>B-2</p>
<p>C-3</p>
<p>D-4</p>
</td>
<td width="320">
<table>
<tbody>
<tr>
<td width="58">
<p>&nbsp;</p>
</td>
<td width="60">
<p>A</p>
</td>
<td width="59">
<p>B</p>
</td>
<td width="59">
<p>C</p>
</td>
<td width="59">
<p>D</p>
</td>
</tr>
<tr>
<td width="58">
<p>1</p>
</td>
<td width="60">
<p><strong>?</strong></p>
</td>
<td width="59">
<p>&nbsp;</p>
</td>
<td width="59">
<p>?</p>
</td>
<td width="59">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="58">
<p>2</p>
</td>
<td width="60">
<p>&nbsp;</p>
</td>
<td width="59">
<p><strong>?</strong></p>
</td>
<td width="59">
<p>?</p>
</td>
<td width="59">
<p><strong>&nbsp;</strong></p>
</td>
</tr>
<tr>
<td width="58">
<p>3</p>
</td>
<td width="60">
<p>?</p>
</td>
<td width="59">
<p><strong>&nbsp;</strong></p>
</td>
<td width="59">
<p><strong>?</strong></p>
</td>
<td width="59">
<p>?</p>
</td>
</tr>
<tr>
<td width="58">
<p>4</p>
</td>
<td width="60">
<p>&nbsp;</p>
</td>
<td width="59">
<p>&nbsp;</p>
</td>
<td width="59">
<p>&nbsp;</p>
</td>
<td width="59">
<p><strong>?</strong></p>
</td>
</tr>
</tbody>
</table>
</td>
<td width="442">
<p>Another correct solution:</p>
<p>A-3</p>
<p>B-2</p>
<p>C-1</p>
<p>D-4</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>Fiddle with your implementation to find the output shown in the examples.</p>
<h3>Hint</h3>
<p>To solve the problem, we can model it as <strong>bipartite graph</strong> where the left nodes are the persons and the right nodes are the tasks and edges show who is able to complete each task. Then we can add <strong>source</strong> and <strong>sink</strong> and model the problem as <strong>max-flow problem</strong> as shown below (all edges have the same capacity 1):</p>
<p>There is another, similar <strong>greedy algorithm</strong>: repeat while possible: connect the nodes having the smallest number of edges, then remove all other nodes connected to these edges. Note that this algorithm works in most scenarios but is wrong in some cases. Can you find a counter-example?</p>
<h2>2. ** Find Bi-Connected Components</h2>
<p>Finding the <strong>articulation points</strong> in an undirected graph is a well-known problem in computer science. A related problem (a bit harder) is to find the <strong>bi-connected components</strong> in a graph &ndash; its set of maximal bi-connected subgraphs. Each bi-connected component has the property that removing any of its nodes, does not break the paths between all its other nodes. Example: the below has 7 bi-connected components: {5, 7}, {12, 7}, {0, 2, 7, 9}, {1, 0, 6}, {6, 8, 11}, {4, 6, 10}, {3, 4}:</p>
<table width="1350">
<tbody>
<tr>
<td width="184">
<p><strong>Input</strong></p>
</td>
<td width="269">
<p><strong>Output</strong></p>
</td>
<td width="586">
<p><strong>Picture</strong></p>
</td>
<td width="311">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="184">
<p>Nodes: 13</p>
<p>Edges: 17</p>
<p>0 1</p>
<p>0 2</p>
<p>0 6</p>
<p>0 7</p>
<p>0 9</p>
<p>1 6</p>
<p>2 7</p>
<p>3 4</p>
<p>4 6</p>
<p>4 10</p>
<p>5 7</p>
<p>6 8</p>
<p>6 10</p>
<p>6 11</p>
<p>7 9</p>
<p>7 12</p>
<p>8 11</p>
</td>
<td width="269">
<p>Number of bi-connected components: 7</p>
</td>
<td width="586">&nbsp;</td>
<td width="311">
<p>5 7</p>
<p>12 7</p>
<p>0 2 7 9</p>
<p>1 0 6</p>
<p>6 8 11</p>
<p>4 6 10</p>
<p>3 4</p>
</td>
</tr>
<tr>
<td width="184">
<p>Nodes: 13</p>
<p>Edges: 20</p>
<p>0 1</p>
<p>0 2</p>
<p>0 6</p>
<p>0 7</p>
<p>0 9</p>
<p>0 11</p>
<p>1 6</p>
<p>2 7</p>
<p>3 4</p>
<p>3 8</p>
<p>4 6</p>
<p>4 10</p>
<p>5 7</p>
<p>5 12</p>
<p>6 8</p>
<p>6 10</p>
<p>6 11</p>
<p>7 9</p>
<p>7 12</p>
<p>8 11</p>
</td>
<td width="269">
<p>Number of bi-connected components: 3</p>
</td>
<td width="586">&nbsp;</td>
<td width="311">
<p>12 7 5</p>
<p>9 0 2 7</p>
<p>1 6 10 4 3 8 11 0</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Hint</strong>: <a href="http://www.cs.umd.edu/class/fall2005/cmsc451/biconcomps.pdf">http://www.cs.umd.edu/class/fall2005/cmsc451/biconcomps.pdf</a></p>
<p>&nbsp;</p>