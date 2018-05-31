<h1>Homework: Advanced Graph Algorithms - Part I</h1>
<p>This document defines the <strong>homework assignments</strong> for the <a href="https://softuni.bg/opencourses/algorithms">"Algortihms" course @ Software University</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cable Network</h2>
<p>A cable networking company plans to extend its existing <strong>cable network</strong> by connecting as many customers as possible within a <strong>fixed budget limit</strong>. The company has calculated the <strong>cost</strong> of building some prospective connections. You are given the existing cable network (a set of <strong>customers</strong> and <strong>connections</strong> between them) along with the <strong>estimated connection costs</strong> between some pairs of customers and prospective customers. A customer can only be connected to the network via a direct connection with an already connected customer. Example:</p>
<p>In the above example we have an existing cable network (the solid blue lines), the estimated costs for connecting some of the customers (dotted blue lines) and a budget limit of 20. Within this budget, the company can connect 3 new customers by the following new connections (solid green lines): {3 &rarr; 5}, {8 &rarr; 7} and {7 &rarr; 1}. The total cost for these new connections will be 2 + 4 + 7 = 13, which fits in the budget limit of 20. No more customers can be connected within this budget limit. Note that each edge, at the time of its addition to the network, connects a new customer with an existing one.</p>
<h3>Examples</h3>
<table width="1371">
<tbody>
<tr>
<td width="297">
<p><strong>Input</strong></p>
</td>
<td width="392">
<p><strong>Picture (Before)</strong></p>
</td>
<td width="268">
<p><strong>Output</strong></p>
</td>
<td width="414">
<p><strong>Picture (After)</strong></p>
</td>
</tr>
<tr>
<td width="297">
<p>Budget: 20</p>
<p>Nodes: 9</p>
<p>Edges: 15</p>
<p>1 4 8</p>
<p>4 0 6 connected</p>
<p>1 7 7</p>
<p>4 7 10</p>
<p>4 8 3</p>
<p>7 8 4</p>
<p>0 8 5 connected</p>
<p>8 6 9</p>
<p>8 3 20 connected</p>
<p>0 5 4</p>
<p>0 3 9 connected</p>
<p>6 3 8</p>
<p>6 2 12</p>
<p>5 3 2</p>
<p>3 2 14 connected</p>
</td>
<td width="392">&nbsp;</td>
<td width="268">
<p>Budget used: 13</p>
</td>
<td width="414">&nbsp;</td>
</tr>
<tr>
<td width="297">
<p>Budget: 7</p>
<p>Nodes: 4</p>
<p>Edges: 5</p>
<p>0 1 9</p>
<p>0 3 4 connected</p>
<p>3 1 6</p>
<p>3 2 11 connected</p>
<p>1 2 5</p>
</td>
<td width="392">&nbsp;</td>
<td width="268">
<p>Budget used: 5</p>
</td>
<td width="414">&nbsp;</td>
</tr>
<tr>
<td width="297">
<p>Budget: 20</p>
<p>Nodes: 8</p>
<p>Edges: 16</p>
<p>0 1 4</p>
<p>0 2 5</p>
<p>0 3 1 connected</p>
<p>1 2 8</p>
<p>1 3 2</p>
<p>2 3 3</p>
<p>2 4 16</p>
<p>2 5 9</p>
<p>3 4 7</p>
<p>3 5 14</p>
<p>4 5 12</p>
<p>4 6 22</p>
<p>4 7 9</p>
<p>5 6 6</p>
<p>5 7 18</p>
<p>6 7 15</p>
</td>
<td width="392">&nbsp;</td>
<td width="268">
<p>Budget used: 12</p>
</td>
<td width="414">&nbsp;</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Modify Prims's algorithm. Until the budget is spent, connect the smallest possible edge from connected node to non-connected node.</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Modified Kruskal Algorithm</h2>
<p>Implement Kruskal's algorithm by keeping the <strong>disjoint sets</strong> in a <strong>forest</strong> where each node holds a <strong>parent + children</strong>. Thus, when two sets need to be merged, the result can be easily optimized to have two levels only: root and leaves. When two <strong>trees are merged</strong>, all nodes from the second (its root + root's children) should be attached to the first tree's root node:</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="1371">
<tbody>
<tr>
<td width="297">
<p><strong>Input</strong></p>
</td>
<td width="392">
<p><strong>Picture (Graph)</strong></p>
</td>
<td width="268">
<p><strong>Output</strong></p>
</td>
<td width="414">
<p><strong>Picture (MST)</strong></p>
</td>
</tr>
<tr>
<td width="297">
<p>Nodes: 4</p>
<p>Edges: 5</p>
<p>0 1 9</p>
<p>0 3 4</p>
<p>3 1 6</p>
<p>3 2 11</p>
<p>1 2 5</p>
</td>
<td width="392">&nbsp;</td>
<td width="268">
<p>Minimum spanning forest weight: 15</p>
<p>(0 3) -&gt; 4</p>
<p>(1 2) -&gt; 5</p>
<p>(1 3) -&gt; 6</p>
</td>
<td width="414">&nbsp;</td>
</tr>
<tr>
<td width="297">
<p>Nodes: 9</p>
<p>Edges: 15</p>
<p>1 4 8</p>
<p>4 0 6</p>
<p>1 7 7</p>
<p>4 7 10</p>
<p>4 8 3</p>
<p>7 8 4</p>
<p>0 8 5</p>
<p>8 6 9</p>
<p>8 3 20</p>
<p>0 5 4</p>
<p>0 3 9</p>
<p>6 3 8</p>
<p>6 2 12</p>
<p>5 3 2</p>
<p>3 2 14</p>
</td>
<td width="392">&nbsp;</td>
<td width="268">
<p>Minimum spanning forest weight: 45</p>
<p>(3 5) -&gt; 2</p>
<p>(4 8) -&gt; 3</p>
<p>(0 5) -&gt; 4</p>
<p>(8 7) -&gt; 4</p>
<p>(0 8) -&gt; 5</p>
<p>(1 7) -&gt; 7</p>
<p>(3 6) -&gt; 8</p>
<p>(6 2) -&gt; 12</p>
</td>
<td width="414">&nbsp;</td>
</tr>
<tr>
<td width="297">
<p>Nodes: 8</p>
<p>Edges: 16</p>
<p>0 1 4</p>
<p>0 2 5</p>
<p>0 3 1</p>
<p>1 2 8</p>
<p>1 3 2</p>
<p>2 3 3</p>
<p>2 4 16</p>
<p>2 5 9</p>
<p>3 4 7</p>
<p>3 5 14</p>
<p>4 5 12</p>
<p>4 6 22</p>
<p>4 7 9</p>
<p>5 6 6</p>
<p>5 7 18</p>
<p>6 7 15</p>
</td>
<td width="392">&nbsp;</td>
<td width="268">
<p>Minimum spanning forest weight: 37</p>
<p>(0 3) -&gt; 1</p>
<p>(1 3) -&gt; 2</p>
<p>(2 3) -&gt; 3</p>
<p>(5 6) -&gt; 6</p>
<p>(3 4) -&gt; 7</p>
<p>(2 5) -&gt; 9</p>
<p>(4 7) -&gt; 9</p>
</td>
<td width="414">&nbsp;</td>
</tr>
</tbody>
</table>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Most Reliable Path</h2>
<p>We have a set of <strong>towns</strong> and some of them are connected by <strong>direct paths</strong>. Each path has a coefficient of reliability (in percentage): the chance to pass without incidents. Your goal is to compute the <strong>most reliable path</strong> between two given nodes. Assume all percentages will be integer numbers and round the result to the second digit after the decimal separator. For example, let's consider the graph below:</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>The <strong>most reliable path</strong> <strong>between 0 and 6</strong> is shown on the right: 0 <strong>&rarr;</strong> 4 <strong>&rarr;</strong> 5 <strong>&rarr;</strong> 3 <strong>&rarr;</strong> 1 <strong>&rarr;</strong> 6. Its cost = 88% * 99% * 98% * 95% * 100% = <strong>81.11%</strong>. The table below shows the optimal reliability coefficients for all paths starting from node 0:</p>
<p>&nbsp;</p>
<table width="1099">
<tbody>
<tr>
<td width="239">
<p><strong>v</strong></p>
</td>
<td width="109">
<p><strong>0</strong></p>
</td>
<td width="131">
<p><strong>1</strong></p>
</td>
<td width="131">
<p><strong>2</strong></p>
</td>
<td width="131">
<p><strong>3</strong></p>
</td>
<td width="94">
<p><strong>4</strong></p>
</td>
<td width="131">
<p><strong>5</strong></p>
</td>
<td width="131">
<p><strong>6</strong></p>
</td>
</tr>
<tr>
<td width="239">
<p><strong>reliability[s &rarr; d]</strong></p>
</td>
<td width="109">
<p>100%</p>
</td>
<td width="131">
<p>81.11%</p>
</td>
<td width="131">
<p>77.05%</p>
</td>
<td width="131">
<p>85.38%</p>
</td>
<td width="94">
<p>88%</p>
</td>
<td width="131">
<p>87.12%</p>
</td>
<td width="131">
<p>81.11%</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<table width="1400">
<tbody>
<tr>
<td width="201">
<p><strong>Input</strong></p>
</td>
<td width="636">
<p><strong>Output</strong></p>
</td>
<td width="563">
<p><strong>Picture</strong></p>
</td>
</tr>
<tr>
<td width="201">
<p>Nodes: 7</p>
<p>Path: 0 &ndash; 6</p>
<p>Edges: 10</p>
<p>0 3 85</p>
<p>0 4 88</p>
<p>3 1 95</p>
<p>3 5 98</p>
<p>4 5 99</p>
<p>4 2 14</p>
<p>5 1 5</p>
<p>5 6 90</p>
<p>1 6 100</p>
<p>2 6 95</p>
</td>
<td width="636">
<p>Most reliable path reliability: 81.11%</p>
<p>0 -&gt; 4 -&gt; 5 -&gt; 3 -&gt; 1 -&gt; 6</p>
</td>
<td width="563">&nbsp;</td>
</tr>
<tr>
<td width="201">
<p>Nodes: 4</p>
<p>Path 0 &ndash; 1</p>
<p>Edges: 4</p>
<p>0 1 94</p>
<p>0 2 97</p>
<p>2 3 99</p>
<p>1 3 98</p>
</td>
<td width="636">
<p>Most reliable path reliability: 94.11%</p>
<p>0 -&gt; 2 -&gt; 3 -&gt; 1</p>
</td>
<td width="563">&nbsp;</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Modify Dijkstra's algorithm.</p>