<h1>Lab: Graph Algorithms</h1>
<p>This document defines the <strong>in-class exercises</strong> assignments for the <a href="https://softuni.bg/opencourses/algorithms">"Algorithms" course @ Software University</a>.</p>
<p>For the following exercises, you are given a Visual Studio solution holding a skeleton + unit tests.</p>
<h1>Part I &ndash; Connected Components</h1>
<p>The first part of this lab aims to implement the <strong>DFS algorithm</strong> (Depth-First-Search) to <strong>traverse a graph</strong> and find its <strong>connected components</strong> (nodes connected to each other either directly, or through other nodes). The graph nodes are numbered from 0 to n-1. The graph comes from the console in the following format:</p>
<ul>
<li>First line: number of lines n</li>
<li>Next n lines: list of child nodes for the nodes 0 &hellip; n-1 (separated by a space)</li>
</ul>
<p>Print the connected components in the same format as in the examples below:</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="184">
<p><strong>Input</strong></p>
</td>
<td width="443">
<p><strong>Graph</strong></p>
</td>
<td width="567">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="184">
<p>9</p>
<p>3 6</p>
<p>3 4 5 6</p>
<p>8</p>
<p>0 1 5</p>
<p>1 6</p>
<p>1 3</p>
<p>0 1 4</p>
<p>&nbsp;</p>
<p>2</p>
</td>
<td width="443">&nbsp;</td>
<td width="567">
<p>Connected component: 6 4 5 1 3 0</p>
<p>Connected component: 8 2</p>
<p>Connected component: 7</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="184">
<p>1</p>
<p>0</p>
</td>
<td width="443">&nbsp;</td>
<td width="567">
<p>Connected component: 0</p>
</td>
</tr>
<tr>
<td width="184">
<p>0</p>
</td>
<td width="443">
<p>(empty graph)</p>
</td>
<td width="567">
<p>Connected component:</p>
</td>
</tr>
<tr>
<td width="184">
<p>7</p>
<p>&nbsp;</p>
<p>2 6</p>
<p>1</p>
<p>4</p>
<p>3</p>
<p>&nbsp;</p>
<p>1</p>
<p>&nbsp;</p>
</td>
<td width="443">&nbsp;</td>
<td width="567">
<p>Connected component: 0</p>
<p>Connected component: 2 6 1</p>
<p>Connected component: 4 3</p>
<p>Connected component: 5</p>
</td>
</tr>
<tr>
<td width="184">
<p>4</p>
<p>1 2 3</p>
<p>0 1 2 3 3</p>
<p>0 1 3</p>
<p>0 1 1 2</p>
</td>
<td width="443">&nbsp;</td>
<td width="567">
<p>Connected component: 3 2 1 0</p>
</td>
</tr>
</tbody>
</table>
<h2>1. DFS Algorithm</h2>
<p>First, create a boolean array that will be with the size of your graph.</p>
<p>Next, implement the <strong>DFS</strong><strong> algorithm </strong>(Depth-First-Search) to traverse all nodes connected to the specified start node:</p>
<h2>2. Test</h2>
<p>Now, test the DFS algorithm implementation from the console-based C# project. Invoke the DFS() method starting from node 0. It should print the connected component, holding the node 0:</p>
<p>Run the code above by <strong>[Ctrl + F5]</strong>. It should print the first connected component in the graph, holding the node 0:</p>
<h2>3. Find All Components</h2>
<p>We want to <strong>find all connected components</strong>. We can just run the DFS algorithm for each node taken as a start (which was not visited already):</p>
<p>Now let's test the above code. Just call it from the main method:</p>
<p>The output is as expected. It prints all connected components in the graph:</p>
<h2>4. Read Input</h2>
<p>Let's implement the data entry logic (read graph from the console). We already have the method below:</p>
<p>Modify the main method to <strong>read the graph from the console</strong> instead using the hard-coded graph:</p>
<p>Now test the program. Run it by [Ctrl] + [F5]. Enter a sample graph data and check the output:</p>
<table>
<tbody>
<tr>
<td width="184">
<p><strong>Input</strong></p>
</td>
<td width="443">
<p><strong>Graph</strong></p>
</td>
<td width="567">
<p><strong>Expected Output</strong></p>
</td>
</tr>
<tr>
<td width="184">
<p>7</p>
<p>&nbsp;</p>
<p>2 6</p>
<p>1</p>
<p>4</p>
<p>3</p>
<p>&nbsp;</p>
<p>1</p>
<p>&nbsp;</p>
</td>
<td width="443">&nbsp;</td>
<td width="567">
<p>Connected component: 0</p>
<p>Connected component: 2 6 1</p>
<p>Connected component: 4 3</p>
<p>Connected component: 5</p>
<p>Connected component: 7</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>5. Run the Unit Tests</h2>
<p>Seems like we solved the graph problem. Let's run the unit tests that come with the program skeleton:</p>
<p>Congratulations! You have implemented the DFS algorithm to find all connected components in a graph.</p>
<h1>Part II &ndash; Source Removal Topological Sorting</h1>
<p>We&rsquo;re given a <strong>directed graph</strong> which means that if node A is connected to node B and the vertex is directed from A to B, we can move from A to B, but not the other way around, i.e. we have a one-way street. We&rsquo;ll call A "<strong>source</strong>" or "<strong>predecessor</strong>" and B &ndash; "<strong>child</strong>".</p>
<p>Let&rsquo;s consider the tasks a SoftUni student needs to perform during an exam &ndash; "Read description", "Receive input", "Print output", etc.</p>
<p>Clearly, some of the tasks <strong>depend on other tasks</strong> &ndash; we cannot print the output of a problem before we get the input. If all such tasks are nodes in a graph, a directed vertex will represent dependency between two tasks, e.g. if A -&gt; B (A is connected to B and the direction is from A to B), this means B cannot be performed before completing A first. Having all tasks as nodes and the relationships between them as vertices, we can <strong>order the tasks using topological sorting</strong>.</p>
<p>After the sorting procedure, we&rsquo;ll obtain a list showing all tasks <strong>in the order in which they should be performed</strong>. Of course, there may be more than one such order, and there usually is, but in general, the tasks which are less dependent on other tasks will appear first in the resulting list.</p>
<p>For this problem, you need to implement topological sorting over a directed graph of strings.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="429">
<p><strong>Input</strong></p>
</td>
<td width="612">
<p><strong>Picture</strong></p>
</td>
<td width="359">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="429">
<p>"A" -&gt; "B", "C"</p>
<p>"B" -&gt; "D", "E"</p>
<p>"C" -&gt; "F"</p>
<p>"D" -&gt; "C", "F"</p>
<p>"E" -&gt; "D"</p>
<p>"F" -&gt;</p>
</td>
<td width="612">&nbsp;</td>
<td width="359">
<p>Topological sorting:</p>
<p>A, B, E, D, C, F</p>
</td>
</tr>
<tr>
<td width="429">
<p>"IDEs" -&gt; "variables", "loops"</p>
<p>"variables" -&gt; "conditionals", "loops", "bits"</p>
<p>"conditionals" -&gt; "loops"</p>
<p>"loops" -&gt; "bits"</p>
<p>"bits"</p>
</td>
<td width="612">&nbsp;</td>
<td width="359">
<p>Topological sorting:</p>
<p>IDEs, variables, conditionals, loops, bits</p>
</td>
</tr>
<tr>
<td width="429">
<p>"5" -&gt; "11"</p>
<p>"7" -&gt; "11", "8"</p>
<p>"8" -&gt; "9"</p>
<p>"11" -&gt; "9", "10", "2"</p>
<p>"9" -&gt;</p>
<p>"3" -&gt; "8", "10"</p>
<p>"2" -&gt;</p>
<p>"10"</p>
</td>
<td width="612">&nbsp;</td>
<td width="359">
<p>Topological sorting: 3, 7, 8, 5, 11, 2, 10, 9</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>We&rsquo;ll solve this using two different algorithms &ndash; source removal and DFS.</p>
<h2>1. Source Removal Algorithm</h2>
<p>The source removal algorithm is pretty simple &ndash; if <strong>finds the node which isn&rsquo;t dependent on any other node</strong> and <strong>removes it</strong> along with all vertices connected to it.</p>
<p>We <strong>continue removing</strong> each node recursively <strong>until we&rsquo;re done</strong> and all nodes have been removed. If there are nodes in the graph after the algorithms is complete, there are circular dependencies (we will throw an exception).</p>
<h2>2. Compute Predecessors</h2>
<p>In order to <strong>efficiently</strong> remove a node at each step, we need to <strong>know the number of predecessors for each node</strong>. To do this, we will calculate the number of predecessors beforehand.</p>
<p>Create a dictionary to store the predecessor count for each node:</p>
<p>Compute the predecessor count for each node:</p>
<h2>3. Remove Independent Nodes</h2>
<p>Now that we know how many predecessors each node has, we just need to:</p>
<ol>
<li>Find a node without predecessors and remove it</li>
<li>Repeat until we&rsquo;re done</li>
</ol>
<p>We&rsquo;ll keep the result in a list and start a loop which will stop when there is no independent node:</p>
<p>Finding a source can be simplified with LINQ. We just need to check if such a node exists; if not, we break the loop:</p>
<p>Removing a node involves several steps:</p>
<ol>
<li>All its child nodes lose a predecessor -&gt; decrement the count of predecessors for each of the children</li>
<li>Remove the node from the graph</li>
<li>Add the node to the list of removed nodes</li>
</ol>
<p>Finally, return the list of removed nodes.</p>
<h2>4. Test</h2>
<p>Run the unit tests. It seems we have a problem:</p>
<p>The last unit tests include graphs with cycles in them. We need to modify our algorithm to take care of cycles.</p>
<h2>5. Detect Cycles</h2>
<p>If we ended the loop and the graph still has nodes, this means there is a cycle. Just add a check after the while loop and throw the proper exception if the graph is not empty:</p>
<h2>6. Test Cycle Detection</h2>
<p>Run the unit tests again. This time they should pass:</p>
<h1>Part III &ndash; DFS Topological Sorting</h1>
<h2>1. DFS Algorithm</h2>
<p>The second algorithm we&rsquo;ll use is <strong>DFS</strong>. You can comment out the method you just implemented and rewrite it in order to use the same unit tests.</p>
<p>For this one, we&rsquo;ll need collection that will store all visited nodes:</p>
<p>The DFS topological sort is simple &ndash; loop through each node. We create a linked list for all sorted nodes, because the DFS will find them in reverse order (we will add nodes in the beginning):</p>
<p>The DFS() method shouldn&rsquo;t do anything if the node is already visited; otherwise, it should mark the node as visited and add it to the list of sorted nodes. It should also do this for its children (if there are any):</p>
<p>Note that we add the node to the result <strong>after</strong> we traverse its children. This guarantees that the node will be added after the nodes that depend on it.</p>
<h2>2. Test</h2>
<p>Run the unit tests. Once again, we have problems with cycles:</p>
<h2>3. Add Cycle Detection</h2>
<p>How do we know if a node forms a cycle? We can add it to a list of cycle nodes before traversing its children. If we enter a node with the same value, it will be in the cycleNodes collection, so we throw an exception. If there are no descendants with the same value then there are no cycles, so once we finish traversing the children we remove the current node from cycleNodes.</p>
<p>Obviously, we&rsquo;ll need a new collection to hold the cycle nodes, e.g. a HashSet&lt;string&gt;. Exiting the method with an exception is easy, just check if the current node is in the list of cycle nodes at the very beginning of the TopSortDFS() method:</p>
<p>Then, keep track of the cycle nodes:</p>
<h2>4. Test Cycle Detection</h2>
<p>Re-run the unit tests. This time they should all pass:</p>
<p>You have implemented topological sorting using two different algorithms!</p>
<p>&nbsp;</p>