<h1>C# OOP Advanced Exam &ndash; The Last Army</h1>
<p>Not too long ago, the protection forces in Bulgaria almost ended. There was almost nobody who can protect our country from the bad guys and the evil which was spreading faster that any time before in history. Street fights, dangerous criminals walking all around and terrorism in not a few places. The last army we left was composed from 3 special forces &ndash; <strong>Ranker</strong>, <strong>Corporal</strong>, <strong>SpecialForce.</strong></p>
<p><strong>Each</strong> of these forces have <strong>special skills</strong> on which they were trained to protect the nation.</p>
<h1>Overview</h1>
<p>You have a task to write a software program, which will generate army, warehouse and will perform different missions. You already have some of the functionalities implemented, although ... the guy that started the project &hellip; well it&rsquo;s obvious he is <strong>quite a rookie</strong> so you need to <strong>refactor</strong> his code and finish the project. The <strong>only</strong> thing he has <strong>done right</strong> is the <strong>class</strong> <strong>MissionController </strong>and<strong> ALL </strong>the<strong> INTERFACES</strong>. You must leave these as they are and <strong>don&rsquo;t modify anything</strong>.</p>
<h1>Task I : Structure</h1>
<p>The main structure of the program should include the following elements:</p>
<ul>
<li><strong>Engine</strong></li>
<li><strong>GameController</strong></li>
<li><strong>MissionController</strong></li>
</ul>
<h2>Soldiers</h2>
<p>An abstract<strong> soldier</strong> has the following characteristics:</p>
<ul>
<li>string &agrave; <strong>name</strong></li>
<li>Int32 &agrave; <strong>age</strong></li>
<li>Double &agrave; <strong>experience</strong><strong>, endurance</strong></li>
</ul>
<p>You need to create three <strong>classes</strong> for each of the three <strong>types</strong> of soldiers we have:</p>
<ul>
<li><strong>Ranker</strong></li>
<li><strong>Corporal</strong></li>
<li><strong>SpecialForce</strong></li>
</ul>
<p>An Army is nothing without weapons. That&rsquo;s why the president of the country gave our special forces the last warehouse which is left. Although it is the last one, it has all the weapons and military equipment which the army needs. In other words, a <strong>soldier does contain a warehouse of weapons</strong>.</p>
<h2>Warehouse (Ammunitions)</h2>
<p>You should create an <strong>abstract</strong> class <strong>Ammunition</strong> with the following parameters:</p>
<ul>
<li>string &agrave; <strong>name</strong></li>
<li>Double &agrave; <strong>weight</strong></li>
</ul>
<p>The following classes, inherit <strong>Ammunition</strong>:</p>
<ul>
<li><strong>Class Gun</strong></li>
<li><strong>Class </strong><strong>AutomaticMachine</strong></li>
<li><strong>Class </strong><strong>MachineGun</strong></li>
<li><strong>Class RPG</strong></li>
<li><strong>Class Helmet</strong></li>
<li><strong>Class </strong><strong>NightVision</strong></li>
<li><strong>Class Knife</strong></li>
</ul>
<h2>Missions</h2>
<p>An <strong>abstract</strong> <strong>class Mission</strong> will have the following <strong>parameters</strong>:</p>
<ul>
<li>Double &agrave; <strong>endurance</strong><strong>Required</strong>, <strong>scoreToComplete</strong></li>
</ul>
<p>The following classes will inherit <strong>Mission </strong>and each of them has a constant value for <strong>enduranceRequired</strong>:&nbsp;</p>
<ul>
<li><strong>Class Easy - 20</strong></li>
<li><strong>Class Medium - 50</strong></li>
<li><strong>Class Hard - 80</strong></li>
</ul>
<h1>Task II: Business Logic</h1>
<h2>Ammunitions Rules:</h2>
<p><strong>Each type</strong> of ammunition has a <strong>specific</strong> constant <strong>weight</strong>, which is the following:</p>
<ul>
<li>AutomaticMachine (<strong>3</strong>)</li>
<li>Gun: (<strong>4</strong>)</li>
<li>Helmet: (<strong>3</strong>)</li>
<li>Knife: (<strong>4</strong>)</li>
<li>MachineGun: (<strong>6</strong>)</li>
<li>NightVision: (<strong>8</strong>)</li>
<li>RPG: (<strong>1</strong>)</li>
</ul>
<p>Every ammunition has also <strong>wear level</strong>, which decreases after each successful mission. Upon creation, each ammunition has a <strong>wear</strong> <strong>level</strong> equal to its <strong>weight * 100</strong>.</p>
<h2>Soldier Rules</h2>
<p>Each type of soldier can wear a different list of ammunitions:</p>
<ul>
<li><strong>Ranker:</strong>
<ul>
<li><strong>Gun</strong></li>
<li><strong>AutomaticMachine</strong></li>
<li><strong>Helmet</strong></li>
</ul>
</li>
<li><strong>Corporal</strong><strong>:</strong></li>
<li><strong>Gun</strong></li>
<li><strong>AutomaticMachine</strong></li>
<li><strong>MachineGun</strong></li>
<li><strong>Helmet</strong></li>
<li><strong>Knife</strong></li>
<li><strong>SpecialForce</strong><strong> -</strong> they are à different story, <strong>they have to wear all the types of ammunitions</strong>, because they are &ldquo;Special&rdquo;.</li>
<li><strong>Gun</strong></li>
<li><strong>AutomaticMachine</strong></li>
<li><strong>MachineGun</strong></li>
<li><strong>RPG</strong></li>
<li><strong>Helmet</strong></li>
<li><strong>Knife</strong></li>
<li><strong>NightVision</strong></li>
</ul>
<p>When you <strong>create a soldier</strong>, you need to check in the <strong>Warehouse</strong>, if <strong>all the ammunitions</strong> for this type of soldier <strong>are available</strong>. If <strong>any</strong> ammunition <strong>is missing</strong>, the soldier <strong>doesn&rsquo;t get</strong> <strong>added</strong> <strong>to the army</strong> and you should print - <strong>"There is no weapon for {type} {name}!"</strong></p>
<p>There is also one very <strong>IMPORTANT </strong>statistic about each soldier<strong> -</strong> his <strong>OverallSkill</strong>, which is the <strong>sum</strong> of a soldiers&rsquo;<strong> age </strong>and<strong> experience</strong>. After adding these numbers together, each <strong>concrete type</strong> of soldier must multiply the result by:</p>
<ul>
<li><strong>Ranker - 1.5</strong></li>
<li><strong>Corporal - 2.5</strong></li>
<li><strong>SpecialForces - 3.5</strong></li>
</ul>
<p>From time to time the soldiers in the army experience <strong>REGENERATION,</strong> which represents an <strong>increase</strong> of their <strong>endurance</strong>. This happens only upon the <strong>Regenerate</strong> <strong>command </strong>and affects only the type of soldiers specified in the command parameters.</p>
<ul>
<li><strong>Ranker&rsquo;s</strong> and <strong>Corporal&rsquo;s</strong> endurance gets increased by <strong>10</strong> <strong>plus the age</strong> of the soldier</li>
<li><strong>SpecialForce</strong> again are special and their endurance gets increased by <strong>30</strong> <strong>plus the age</strong> of the soldier</li>
</ul>
<p>A soldier&rsquo;s <strong>endurance</strong> should <strong>never exceed the amount of</strong> <strong>100</strong>! The unwanted endurance just disappears, without any error generated.</p>
<p><strong>Before</strong> <strong>each</strong> mission, you need to <strong>check</strong> which soldiers in the army <strong>are ready for the mission</strong>. There are three conditions for a soldier to participate in a mission:</p>
<ol>
<li>He needs to have <strong>enough endurance</strong> for the current mission ;</li>
<li>He has to be <strong>equipped with all needed ammunitions</strong> for this type of solder;</li>
<li><strong> All his ammunitions</strong> need to have <strong>at least positive value of wear level</strong>.</li>
</ol>
<p><strong>Before</strong> you send soldier on mission, <strong>you have to check in the Warehouse for ammunitions</strong>. They might be created later. Each soldier replaces his worn out ammunitions with the currently available in the Warehouse, if they are available. If a soldier <strong>doesn&rsquo;t get fully equipped</strong> (gathers all the needed ammunitions) he <strong>keeps the ammunitions</strong> <strong>he has found</strong> but still does not participate in the mission.</p>
<p>In order to participate in a mission, a soldier <strong>MUST</strong> be equipped with <strong>all the ammunitions</strong>, which <strong>he can wear</strong> corresponding to his type.</p>
<h2>Missions Rules</h2>
<p><strong>Performing</strong> missions is <strong>done immediately after its creation</strong> and can be successful &hellip; or not. If a <strong>mission is unsuccessful it is put on hold</strong> while there is a team that is capable of executing it. Although the <strong>maximum number of missions on hold is 3</strong>. If there is a <strong>forth</strong> mission called, the <strong>oldest one is declined</strong>.</p>
<h3>Easy</h3>
<p>The <strong>first</strong> <strong>mission (Easy) </strong>is named &ldquo;<strong>Suppression of civil rebellion</strong>&rdquo; is the <strong>easiest</strong> one. Here is some more specific information about that mission:</p>
<ul>
<li>The <strong>endurance </strong>of the soldiers <strong>goes down</strong> by<strong> 20 after completing the mission</strong></li>
<li>The <strong>wear</strong> <strong>level</strong> of <strong>EACH </strong>ammunition of the soldiers <strong>decreases by 30 after completing the mission</strong></li>
<li>Only soldiers who have <strong>AT LEAST</strong> <strong>20</strong> <strong>endurance</strong> can <strong>participate in it</strong></li>
</ul>
<p>&nbsp;</p>
<h3>Medium</h3>
<p>The <strong>Second</strong> <strong>mission (Medium)</strong> is named &ldquo;<strong>Capturing dangerous criminals</strong>&rdquo;. Here is more information about the mission:</p>
<ul>
<li>The <strong>endurance</strong> of the soldiers <strong>goes down</strong> by<strong> 50 after completing the mission </strong></li>
<li>The<strong> wear level</strong> of <strong>EACH</strong> ammunition of the soldiers <strong>decreases by 50 after completing the mission</strong></li>
<li>Only soldiers who have <strong>AT LEAST</strong> <strong>50</strong> <strong>endurance </strong>can <strong>participate in it</strong></li>
</ul>
<h3>Hard</h3>
<p>The <strong>last</strong> <strong>mission</strong> <strong>(Hard)</strong> which is the hardest one and most dangerous one - &ldquo;<strong>Disposal of terrorists</strong>&rdquo;. Here is more information about the mission:</p>
<ul>
<li>The <strong>endurance</strong> of the soldiers <strong>goes down</strong> by<strong> 80 after completing the mission</strong></li>
<li>The<strong> wear level</strong> of <strong>EACH</strong> ammunition of the soldiers <strong>decreases by 70 </strong>after completing the mission</li>
<li>Only soldiers who have <strong>AT LEAST</strong> <strong>80</strong> <strong>endurance </strong>can <strong>participate in it</strong></li>
</ul>
<p>À mission gets completed if the <strong>sum</strong> of <strong>all participating</strong> soldiers <strong>overall skill</strong> is <strong>equal or bigger</strong> than the missions&rsquo; <strong>score to complete</strong>.</p>
<p>At the end of à <strong>successfully completed</strong> mission all soldiers that took part in the mission <strong>gain experience</strong> <strong>equal to endurance</strong> <strong>required for the mission</strong>.</p>
<p>After <strong>the end of the input</strong> all missions which are <strong>left on hold</strong> must be counted as <strong>FAILED</strong>!</p>
<h2>Commands</h2>
<ol>
<li><strong>Adding</strong> a soldier to the army</li>
</ol>
<p>Soldier [Type] [Name] [Age] [Experience] [Endurance]</p>
<ol start="2">
<li><strong>Adding</strong> ammunitions to the warehouse</li>
</ol>
<p>WareHouse [Name] [Count]</p>
<ol start="3">
<li><strong>Missions</strong> command:</li>
</ol>
<p>Mission [Type] [Score to Complete]</p>
<ol start="4">
<li><strong>Regenerating</strong> soldiers command:</li>
</ol>
<p>Soldier Regenerate [Soldier Type]</p>
<p>&nbsp;</p>
<h1>Tasks III:</h1>
<h2>Reflection</h2>
<p>You need to refactor given factories and implement new ones. Factories have to <strong>use reflection</strong>, so it will be easy for us to follow <strong>Open/Closed Principe</strong>. You need to have <strong>three factories</strong>:</p>
<ul>
<li><strong>Class SoldierFactory</strong></li>
<li><strong>Class AmmunitionFactory</strong></li>
<li><strong>Class MissionFactory</strong></li>
</ul>
<p>Your task is to implement these factories in such a way that it will be <strong>easy to extend the number of concrete types of each entity</strong>. With simple words, your factories need to work the same way without modifications, if someone <strong>adds a new class</strong>, which <strong>implements </strong>ISoldier<strong>, </strong>IAmmunition<strong> and </strong>IMission</p>
<p><strong>No static </strong>factories are allowed<strong>!</strong></p>
<h2>Unit Testing</h2>
<p>Like you see at the beginning there is à class, which does not need refactoring - MissionController<strong>. </strong>This is the class, against which you need to <strong>write unit tests</strong>. For easy testing, there is some stuff that are not high quality (setters are public), but you can use them in your unit tests. In your skeleton, the MissionController is working <strong>perfect</strong>, but it still needs to be tested, because in <strong>Judge</strong> we have prepared some <strong>bugs</strong> and you need to catch them in your unit tests.</p>
<p>Do <strong>NOT</strong> use <strong>Mocking</strong> in your unit tests!</p>
<h2>Input</h2>
<ul>
<li>The input will come from the console in the form of commands, in the format specified above - each command on new line</li>
<li>The input sequence ends when you receive the command &ldquo;<strong>Enough! Pull back!</strong>&rdquo;</li>
<li><strong>Any</strong> type of command, except the &ldquo;<strong>Enough! Pull back!</strong>&rdquo; can be given at any time.</li>
</ul>
<h2>Output</h2>
<p>Upon creating Soldier command, if it is <strong>not possible to equip the soldier with ammunitions</strong> and thus add him to the army, print:</p>
<ul>
<li>&ldquo;<strong>There is no weapon for {Soldier Type} {Name}!</strong>&rdquo;</li>
</ul>
<p>Upon <strong>each </strong>Mission<strong> command</strong>, you should print on the console:</p>
<ul>
<li>If there is <strong>no room in the mission queue</strong> for the incoming mission: &ldquo;<strong>Mission declined - {Name}</strong>&rdquo;</li>
</ul>
<p>For each mission, <strong>currently in the queue</strong>, print:</p>
<ul>
<li>If the mission is successful: &ldquo;<strong>Mission completed - {Name}</strong>&rdquo;</li>
<li>If the mission is unsuccessful: &ldquo;<strong>Mission on hold - {Name}</strong>&rdquo;</li>
</ul>
<p>The next lines of the output have to be printed at the end, after receiving the command "<strong>Enough! Pull back!</strong>".</p>
<p>First, you need to print summary for all the missions in the format:</p>
<p><strong>Results:</strong></p>
<p><strong>Successful missions - {number}</strong></p>
<p><strong>Failed missions - {number}</strong></p>
<p>Then you need to print all soldiers in the army, in <strong>descending order by their overall skill</strong> in the format:</p>
<p><strong>Soldiers:</strong></p>
<p><strong>{Name} - {OverallSkill}</strong></p>
<h2>Constrains</h2>
<ul>
<li><strong>All </strong><strong>ints</strong> in the input will be in the <strong>range [0, 1000]</strong></li>
<li><strong>All </strong><strong>Doubles </strong>will be in the <strong>range [0, 1000]</strong></li>
<li>All input lines will be <strong>VALID</strong> command</li>
<li>There will be <strong>NO MORE</strong> than <strong>500</strong> commands</li>
<li><strong>All</strong> rules <strong>specified above</strong> will be <strong>strictly</strong> <strong>followed</strong>, there will be <strong>NO</strong> unexpected input or conditions</li>
</ul>
<h2>Examples</h2>
<table width="1415">
<tbody>
<tr>
<td width="619">
<p><strong>Input</strong></p>
</td>
<td width="795">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="619">
<p>WareHouse AutomaticMachine 4</p>
<p>WareHouse Gun 6</p>
<p>WareHouse Helmet 20</p>
<p>Soldier Ranker Ivan 28 55 100</p>
<p>Mission Easy 150</p>
<p>Enough! Pull back!</p>
</td>
<td width="795">
<p>Mission on hold - Suppression of civil rebellion</p>
<p>Results:</p>
<p>Successful missions - 0</p>
<p>Failed missions - 1</p>
<p>Soldiers:</p>
<p>Ivan - 124.5</p>
</td>
</tr>
<tr>
<td width="619">
<p>WareHouse AutomaticMachine 30</p>
<p>WareHouse Gun 2</p>
<p>WareHouse Helmet 9</p>
<p>Mission Easy 1500</p>
<p>Soldier Ranker Ivan 47 23 100</p>
<p>WareHouse Knife 8</p>
<p>WareHouse MachineGun 4</p>
<p>Soldier Corporal Ivaylo 21 78 100</p>
<p>Mission Medium 180</p>
<p>Enough! Pull back!</p>
</td>
<td width="795">
<p>Mission on hold - Suppression of civil rebellion</p>
<p>Mission on hold - Suppression of civil rebellion</p>
<p>Mission completed - Capturing dangerous criminals</p>
<p>Results:</p>
<p>Successful missions - 1</p>
<p>Failed missions - 1</p>
<p>Soldiers:</p>
<p>Ivaylo - 372.5</p>
<p>Ivan - 180</p>
</td>
</tr>
<tr>
<td width="619">
<p>Mission Hard 5000</p>
<p>Mission Hard 12</p>
<p>Mission Hard 12</p>
<p>Mission Hard 12</p>
<p>WareHouse AutomaticMachine 5</p>
<p>WareHouse RPG 2</p>
<p>WareHouse NightVision 4</p>
<p>WareHouse AutomaticMachine 30</p>
<p>WareHouse Gun 2</p>
<p>WareHouse Helmet 9</p>
<p>Soldier Ranker Ryan 47 23 100</p>
<p>Mission Hard 12</p>
<p>WareHouse Knife 8</p>
<p>WareHouse MachineGun 4</p>
<p>Soldier Corporal Gosho 21 10 100</p>
<p>Soldier Regenerate Corporal</p>
<p>Soldier Ranker Pijo 79 19 50</p>
<p>Mission Medium 79</p>
<p>Enough! Pull back!</p>
</td>
<td width="795">
<p>Mission on hold - Disposal of terrorists</p>
<p>Mission on hold - Disposal of terrorists</p>
<p>Mission on hold - Disposal of terrorists</p>
<p>Mission on hold - Disposal of terrorists</p>
<p>Mission on hold - Disposal of terrorists</p>
<p>Mission on hold - Disposal of terrorists</p>
<p>Mission declined - Disposal of terrorists</p>
<p>Mission on hold - Disposal of terrorists</p>
<p>Mission on hold - Disposal of terrorists</p>
<p>Mission on hold - Disposal of terrorists</p>
<p>Mission declined - Disposal of terrorists</p>
<p>Mission completed - Disposal of terrorists</p>
<p>Mission on hold - Disposal of terrorists</p>
<p>Mission on hold - Disposal of terrorists</p>
<p>There is no weapon for Ranker Pijo!</p>
<p>Mission completed - Disposal of terrorists</p>
<p>Mission on hold - Disposal of terrorists</p>
<p>Mission on hold - Capturing dangerous criminals</p>
<p>Results:</p>
<p>Successful missions - 2</p>
<p>Failed missions - 4</p>
<p>Soldiers:</p>
<p>Gosho - 277.5</p>
<p>Ryan - 225</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>