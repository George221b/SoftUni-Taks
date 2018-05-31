<h1>Lab: Advanced Graph Algorithms</h1>
<p>This document defines the <strong>in-class exercises</strong> assignments for the <a href="https://softuni.bg/opencourses/algorithms">"Algorithms" course @ Software University</a>.</p>
<p>For the following exercises you are given a Visual Studio solution "<strong>Advanced-Graph-Algorithms-II-Lab</strong>" holding portions of the source code + unit tests. You can download it from the course&rsquo;s page.</p>
<h1>Part I &ndash; Strongly Connected Components (SCC) &ndash; Kosaraju- Sharir Algorithm</h1>
<p>A strongly connected component is any subgraph in a graph that fulfills the prerequisite that for any two vertices <strong>u</strong> and <strong>v </strong>in the subgraph there exists a path from <strong>u</strong> to <strong>v</strong>.</p>
<p>For example, you want to check if all towns on a map are actually <strong>reachable</strong> using the current <strong>road network</strong>. The towns are represented as vertexes and the roads are represented as edges. To find the groups in which all towns can reach one another we need an algorithm for finding <strong>Strongly Connected Components (SCC)</strong>.</p>
<p>We can use the <a href="https://en.wikipedia.org/wiki/Kosaraju%27s_algorithm">Kosaraju-Sharir</a> algorithm.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="728">
<p><strong>Graph</strong></p>
</td>
<td width="648">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="728">&nbsp;</td>
<td width="648">
<p>Strongly Connected Components:</p>
<p>{5}</p>
<p>{8}</p>
<p>{10}</p>
<p>{11}</p>
<p>{3, 4}</p>
<p>{7, 12}</p>
<p>{0, 1, 2, 6, 9, 13}</p>
</td>
</tr>
</tbody>
</table>
<h2>1. Run the Unit Tests</h2>
<p>Run the unit tests in the <strong>StronglyConnectedComponents.Tests</strong> project. Since we haven&rsquo;t written the algorithm yet, so they should all fail:</p>
<p>&nbsp;</p>
<h2>2. Start with a Hardcoded Example</h2>
<p>In the <strong>StronglyConnectedComponentsMain</strong> class you&rsquo;re provided with a test case &ndash; a graph with 14 nodes represented as an adjacency list. Your task is to complete the FindStronglyConnectedComponents() method in the <strong>StronglyConnectedComponents</strong> class, which receives the graph and returns the strongly connected components as a <strong>List&lt;List&lt;int&gt;&gt;</strong>, where each inner list represents a <strong>strongly connected component</strong> (scc).</p>
<p>This is how this graph looks like:</p>
<h2>3. Initialize Variables</h2>
<p>We should store the passed in graph and <strong>initialize the collection</strong> that will keep the results.</p>
<h2>4. DFS</h2>
<p>The <strong>Kosaraju-Sharir</strong> algorithm works by first finding all components of the graph. This can be done by using DFS, each time a DFS finishes all visited elements represent a connected component. For every component we also want the order in which we visited the vertexes, we can store this information by using a <strong>Stack</strong>, every time the DFS returns from a vertex (all its children have been visited) we <strong>add the vertex to the Stack</strong>. Since the first vertex that will be added to the Stack is the deepest one, when we&rsquo;re finished on top of the Stack will be the vertex we started from.</p>
<h2>5. Build Reverse Graph</h2>
<p>After knowing all connected components we have all connected components, we need to build the reverse graph. Building it is not hard we loop through the adjacency list and for each connection <strong>u -&gt; v</strong> we instead add a connection <strong>v -&gt; u</strong> in the reversed graph:</p>
<h2>6. Reverse DFS</h2>
<p>After we have the reversed graph, we can find the strongly connected components.</p>
<p>The conjecture is the following, if a vertex is part of a <strong>SCC</strong> (strongly connected component), then there is a path from that vertex to any other in the SCC and from any other in the SCC to that vertex, if that is true than reversing the edges should not change this (if there is a path from <strong>u -&gt; v</strong> and from <strong>v -&gt; u</strong>, then reversing the edges would mean there is a path from <strong>v -&gt; u</strong> and from <strong>u -&gt; v</strong>).</p>
<p>Starting from the top of the Stack we pop an element and start a DFS in the reversed graph:</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>Every time the ReverseDFS function finishes all nodes we visited represent a strongly connected component.</p>
<p>Once you&rsquo;re done, run the program. It should produce the following result:</p>
<p>And this is the result visually:</p>
<h2>7. Run the Unit Tests Again</h2>
<p>This time all tests should pass:</p>
<p>You&rsquo;ve successfully implemented the <strong>Kosaraju-Sharir</strong> algorithm!</p>
<h1>Part II &ndash; Articulation Points</h1>
<p>Sometimes we need to find articulation points (cut vertices) in a certain network &ndash; <strong>points that when removed will split the graph into separated components</strong>.</p>
<p>In situations such as networks for ISPs (Internet Service Providers), electricity or water it is very important to have redundancy in the networks. If between every vertex <strong>u</strong> and vertex <strong>v </strong>in a network there existed at least 2 different paths (paths that have no vertexes in common aside from the beginning and the end vertex) such a network would be called <strong>biconnected</strong>. However if there existed some point <strong>x </strong>(different from <strong>u</strong> and <strong>v</strong>) which is always a part of any path between <strong>u</strong> and <strong>v</strong>, such a point would be an articulation point.&nbsp;</p>
<p>Let&rsquo;s implement the <a href="https://en.wikipedia.org/wiki/Biconnected_component">Hopcroft-Tarjan</a> algorithm for finding the articulation points in the following graph:</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="1322">
<tbody>
<tr>
<td width="783">
<p><strong>Graph</strong></p>
</td>
<td width="539">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="783">&nbsp;</td>
<td width="539">
<p>Articulation points: 4, 6, 7, 0</p>
</td>
</tr>
</tbody>
</table>
<h2>1. Run the Unit Tests to Make Sure They Initially Fail</h2>
<p>The algorithm is still not implemented, so all unit tests should fail:</p>
<h2>2. Initialize Collections</h2>
<p>First, we&rsquo;ll initialize the collections we need, we&rsquo;ll need something to <strong>store the graph</strong> we&rsquo;ll work with and we can also initialize a collection to <strong>keep the articulation points</strong>, we&rsquo;ll also need collections to <strong>hold the depths</strong>, <strong>lowpoints</strong>,&nbsp; <strong>parents of the vertices</strong> and a collection to <strong>keep visited vertices</strong>:</p>
<h2>3. Create the Main Recursive Function</h2>
<p>Our algorithm works on the basis of DFS, we need to <strong>create the recursive function</strong>, as parameters we&rsquo;ll pass the index of the <strong>starting node</strong> and the <strong>starting depth</strong>:</p>
<p>In the beginning of the function we&rsquo;ll <strong>mark the current node as visited</strong> and <strong>initialize its depth</strong> and <strong>lowpoint</strong> to the depth parameter.</p>
<p>Locally in the stack frame we&rsquo;ll also <strong>keep track of the number of children of the vertex</strong> and to simplify our checks we&rsquo;ll also use a variable to keep track if the current point is an articulation point.</p>
<h2>4. Implement the Main Loop</h2>
<p>As we mentioned the algorithm is based on DFS, so we&rsquo;ll implement the main loop in a DFS where we traverse all children of a vertex. If a child isn&rsquo;t already visited, we <strong>mark its parent</strong> as the current vertex and <strong>recursively call the function for the child with an increased depth</strong>:</p>
<p>After returning from the recursion, we <strong>increment the child count</strong> and <strong>compare the lowpoint of the child compared to the depth of the current vertex</strong>. If the child&rsquo;s lowpoint is equal to or bigger than the current depth, we know it hasn&rsquo;t found a different path to a previous node, so the current vertex must be an articulation point. After the check, we <strong>set the lowpoint for the current vertex</strong> to be the smaller between itself and the child&rsquo;s lowpoint.</p>
<p>In case the child was visited, but is not our direct parent (so we avoid the situation where we go to a child and check back to where we came from) we <strong>set the lowpoint of the current vertex</strong> to be the smaller of itself and the depth of the visited child:</p>
<p>After we have visited all children of a vertex we can conclude whether it&rsquo;s an articulation point or not. If the current vertex is the starting vertex and it has at least 2 children (each in a different component) it&rsquo;s an articulation point, alternatively if it&rsquo;s not the starting node and the <strong>isArticulation</strong> Boolean is true it&rsquo;s also an articulation point.</p>
<p>Once you&rsquo;re done, run the program. It should produce the following result:</p>
<h2>5. Run the Unit Tests Again</h2>
<p>If you&rsquo;ve completed all tasks correctly, the unit test should now pass:</p>
<p>Congratulations! You have successfully completed the Hopcroft-Tarjan algorithm for finding articulation points!</p>
<h1>Part III &ndash; Max Flow algorithm - Edmonds-Karp</h1>
<p>Max flow algorithms are pretty important, because a lot of problems can be modified and then represented as a max flow problem. In this problem, we&rsquo;ll try to implement one such Max flow algorithm &ndash; the <a href="https://en.wikipedia.org/wiki/Edmonds%E2%80%93Karp_algorithm">Edmonds-Karp</a> algorithm.</p>
<p>Example</p>
<p>Find the maximum flow possible in the network starting from <strong>node 0</strong> and ending in <strong>node 5</strong></p>
<table>
<tbody>
<tr>
<td width="860">
<p><strong>Graph</strong></p>
</td>
<td width="539">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="860">&nbsp;</td>
<td width="539">
<p>Max flow = 19</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>1. Provided Assets</h2>
<p>You are provided with a test case in the <strong>EdmondsKarp</strong>Main() method. The graph is given as an adjacency matrix where the rows and the columns are the vertexes and the cells represent the capacity of the edge. For example cell <strong>[2, 4]</strong> with value 50 would mean that there is an edge from <strong>node 2</strong> to <strong>node 4</strong> with <strong>capacity 50</strong>, if a cell&rsquo;s value is 0 then there is no edge between the nodes.</p>
<h2>2. Run the Unit Tests to Make Sure They Initially Fail</h2>
<p>Run the Unit Tests to Make Sure They Initially Fail</p>
<p>The algorithm is still not implemented, so all unit tests should fail:</p>
<h2>3. Initialize Structures</h2>
<p>Max flow algorithms rely on <strong>finding a path</strong> from the <strong>start vertex (source)</strong> to the <strong>end vertex (sink)</strong>. Such a path is called an augmenting path, after finding such a path we usually have to trace it back to the start so we need to keep a collection to see where we came from. We&rsquo;ll create an <strong>array for keeping track of the parents of vertexes</strong>, in order to know if we have set a parent for a vertex or not we&rsquo;ll initialize the parents array with starting value <strong>-1</strong>:</p>
<h2>4. Find Augmenting Paths</h2>
<p>The key point in Max flow algorithms is finding an augmenting path, the <strong>Edmonds-Karp</strong> algorithm is an implementation of the <strong>Ford-Fulkerson</strong> algorithm where we find the augmenting path using BFS:</p>
<h2>5. Reconstruct Path</h2>
<p>While the BFS algorithm keeps finding augmenting paths, we&rsquo;ll traverse the path starting from the end/sink back, while keeping track of the <strong>smallest edge capacity</strong> we&rsquo;ve passed. We keep track of the smallest capacity in our path, because the most amount of flow we can pass through the path is at most the amount we can pass through the smallest edge.</p>
<h2>6. Modify the Graph</h2>
<p>After finding the most flow we can have through the augmenting path, we <strong>add it to the max flow</strong> and then we modify the graph to <strong>mark that we have filled the found augmenting path</strong>. We subtract from each edge in the augmenting path&rsquo;s capacity the amount of flow we&rsquo;ve run through the path and increase the capacity of the reverse edges with the same amount:</p>
<p>With this we should be done the only thing left is to return the max flow.</p>
<p>If you&rsquo;ve done everything correctly, you should get:</p>
<h2>7. Run the Unit Tests Again</h2>
<p>If you&rsquo;ve completed all tasks correctly, the unit test should now pass:</p>
<p>Congratulations! You&rsquo;ve implemented the <strong>Edmonds-Karp</strong> algorithm!</p>