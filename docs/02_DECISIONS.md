# Decision ledger — approved, tentative, and rejected

**Snapshot date:** 2026-11-13. This is the authoritative reference for **what is actually decided**. Read with docs/06_DISCUSSION_HISTORY.md to see why corrections were made.

## CONFIRMED — game identity

- Original game, **not** a mod/modpack for Valheim. Krumpac/Valheim modding was mentioned only as inspiration/context.
- Valheim-inspired survival/exploration/building/freedom is the **foundation**; Metin2-inspired progression/loot/classes/NPCs/dungeons is the major complement; New World contributes a **small profession progression add-on**.
- Single-player and co-op friend-group play; chill, voluntary pacing; no competitive MMORPG progression obligations.
- A player can focus on building, grinding, or exploring without class-based survival restrictions.
- We start by building an **ugly prototype** and testing it, not by exhaustively planning the full game.
- Unity chosen over Godot for this trial, despite Godot being acceptable; Unreal explicitly disliked. Engine decision can be revisited on evidence, not just speculation.

## CONFIRMED — starting world and progression direction

- Starting settlement inspired by Metin2's **Map1**, visually/atmospherically mixed with Valheim's medieval/grounded world.
- The **blacksmith is definitely wanted**. Other town NPCs are needs-driven, not a mandatory fixed list.
- Town is the player's **early-game base**, with possibly a few mid/late-game unlocks or reasons to revisit.
- **No player building inside the established starting town**; players eventually build their own home in the surrounding world.
- Exploration, story, quests, monster fighting, **more dungeons and bosses**, and gear farming are central desired additions.
- **Character levels** are wanted (even in solo/co-op); not strictly an MMO.
- No hard dungeon-level entry barriers. Underleveled clears through personal skill, equipment, food, buffs, and/or teamwork should be possible.
- Classes **yes**: likely each has a limited/small selection of compatible weapon types. Class determines combat identity, not survival/gathering/homebuilding access. Exact roster and abilities are undecided.
- **Every class should be able to finish the game alone.** Different boss times are acceptable; combat effectiveness can later be tuned via damage/resistances and bonuses.
- Supports are **valuable but never mandatory**; support synergy may allow a party at level ~18–20 to clear a dungeon normally comfortable around level ~30 (numbers illustrative).

## CONFIRMED — world structure decision 1 (2026-11-14)

- **Option A explicitly selected:** Addiction² uses **one physically continuous, explorable main world**, Valheim-style, rather than a Metin2-style overworld divided into separate connected maps or portal-only regions.
- **Authored locations inside generated land:** the Map1-inspired starting settlement and other important places are authored/hand-placed **within** the continuously explorable generated world, not a separately loaded Map1 overworld. The two town entry paths lead naturally into the surrounding landscape; they are not map-transfer portals.
- **Unresolved independently:** dungeon interiors/scenes/instances, optional teleports or fast travel, streaming/scene loading behind the scenes, world size and limits, island/continent geography, and terrain-generation algorithm. A seamless-feeling world does not rule out technical streaming.
- **Rationale:** preserve Valheim-like exploration, sailing possibilities, player-chosen home locations and an inhabitable shared world, while borrowing Metin2's crafted town identity and recognizable RPG locations.

## DIRECTION / EXPERIMENT — ocean-and-islands geography (2026-11-14)

- **World-design Decision #2 is deliberately provisional:** director personally **prefers Option A**, a Valheim-like world of islands and oceans, and explicitly wants to **experiment with it**, rather than approving a final world-generation topology.
- **Option C (large starting continent plus distant islands)** remains an alternative but is currently less preferred. The director considers **mounts likely necessary if Option C is chosen** because of longer overland travel. This is a design concern, **not an approved mounts feature or mandatory NPC**.
- **Testing implications:** start with the experience of exploring/building on a landmass and eventually crossing water; avoid implementing boats/mounts simply because a map category was mentioned. When sailing becomes necessary, archipelago spacing, biome placement and number of landmasses all remain undecided.

## CONFIRMED — starting-island experience (world decision 3, 2026-11-14)

- Director chose **Option B: medium-to-large starting island** within the experimental ocean-and-islands world direction. The starting landmass should provide substantial room for exploring and building around the Map1-inspired starting town **without requiring a boat immediately**.
- **Not yet decided:** exact island size or traversal time, number of biomes/resources, coastline shape, location of other islands, when sailing becomes necessary and technical world generation settings. “Medium-to-large” is an experience target, not a locked size in square kilometers.
- **Relationship to Decision #2:** choosing starting-island B does **not** finalize the broader archipelago/world topology; island-and-ocean geography remains the preferred approach to experiment with.

## CONFIRMED — starting-town placement (world decision 4, 2026-11-14)

- Director chose **Option C: inland but relatively near the coast** on the medium-to-large starting island. The Map1-inspired settlement should feel like a town among land, forests and hills, **not a seafront town**, while the coastline is reachable through exploration.
- This does **not** approve a fixed walking distance, a harbor/dock, a specific road to the sea, an ocean view from town, or the position of the town on every generated island.
- The previously drawn two entrance routes remain **two land routes to the surrounding world**; their precise directions and whether either eventually reaches the coast are undecided.

## CONFIRMED — town integration in generated worlds (world decision 5, 2026-11-14)

- Director selected **Option B: a recognizable, handcrafted town layout with procedurally varied surroundings and suitable placement per generated world**. Core town arrangement should remain recognizably authored; nearby terrain, forests, hills and coastlines should differ between world seeds.
- **The town must fit its location naturally**, with paths meeting the landscape. The implementation approach (terrain shaping, placement constraints, road blending, generator rules) is **not yet chosen**; do not assume a runtime pasted prefab or hand-code a fixed location.
- Maintain the **two entrances**, inland-near-coast character and prohibition on building inside the town. The broader islands-and-oceans topology remains **preferred for experiments**, not fully fixed.

## CONFIRMED — biome identity and consistent baseline danger (world decision 6, 2026-11-14)

- Director chose **Option A: consistent baseline difficulty by biome across the world**, after previously favoring a mixture of Valheim's biome danger and Metin2-style varied encounters. A biome should generally communicate a learnable danger level wherever it appears; **do not make an ordinary Dark Forest on a distant island inherently much higher-level than the same Dark Forest near the start**.
- The earlier hybrid interest remains compatible: **identifiable exceptional locations or enemies** (camps, elites, bosses, dungeons) may exceed the surrounding biome's baseline, with appropriate visual or gameplay warning. Their presence should not make ordinary enemies unpredictable.
- This confirms the **relative biome consistency principle**, **not** biome names, exact enemy levels, scaling formulas, level-gating rules, map distributions, or enemy rosters. See World Decision #7 for the chosen two-tier starting-island experience.


## CONFIRMED — starting-island biome scope (world decision 7, 2026-11-14)

- Director chose **Option B: the starting island should contain a beginner-friendly biome plus the first meaningfully more dangerous biome**. This gives players room to explore, gather, build, and experience an early rise in biome difficulty **before sailing becomes necessary**.
- The **handcrafted starting town** is located in the safer portion of the island; the second biome must be reached by normal land exploration without requiring a boat. Players should be free to choose when to explore it.
- This is a **high-level gameplay distribution**, not approval of exactly two biome types in the complete game, biome names, level brackets, exact land proportions, hard gates, or a fixed island template. Distinct elite camps/dungeons can still be exceptional encounters within the baseline biome danger system.
- The overall ocean/island geography remains a **preferred approach for experimentation**. Test traversal and world-building feel before fixing precise geography or generation rules.

## CONFIRMED — biome placement across the world (world decision 8, 2026-11-14)

- Director delegated the choice between **A (Valheim-style distance progression)** and **C (guided randomness)** to design planning, saying both seem good. **Chosen: C, with A's distance-based progression as the dominant backbone**.
- **Generator design rule, not a fixed algorithm:** more dangerous biome types should become **more common farther from the starting area**, so outward exploration generally feels progressive. The starting island still guarantees a safe beginner biome and the first more dangerous biome (Decision #7).
- **Meaningful but controlled exceptions:** distant islands may still have safe biomes, and relatively nearby islands may have some higher-risk terrain **provided the first-play safety and travel experience remain fair**. Do not distribute danger completely randomly or force a player to cross an unexpectedly extreme biome to reach ordinary early content.
- **Biome consistency remains intact (Decision #6):** a biome's ordinary encounter baseline does not scale with distance. Distance affects **probability of biome occurrence**, **not** the enemy levels inside the same biome.
- Exact distance curves, world radius, biome counts, rarity probabilities, island layout, guaranteed routes and generation algorithms are **undecided** and need empirical world-generation/exploration tests. Overall island-and-ocean geography is still a **preferred experimental direction** rather than a completely locked implementation.

## CONFIRMED — modifiable outdoor terrain (world decision 9, 2026-11-14)

- Director chose **Option A: Valheim-style terrain deformation**. Players should eventually be able to **dig/lower, raise, flatten and reshape outdoor ground** for building foundations, roads and landscaping.
- This is an **intended gameplay capability** that matters early for generated terrain, building placement, world-state persistence and co-op authority; it is **not** authorization to implement every tool immediately.
- **Scope clarification:** this decision does **not** automatically require full voxel terrain, caves, horizontal tunnels or arbitrarily deep excavation. Those are materially different technical/gameplay questions that remain open. Terrain depth/height limits, materials, tool unlocks, building protection and costs are also unchosen.
- Terrain edits in shared worlds must ultimately survive saving and reloading, and should not be overwritten by procedural regeneration. The technical representation/network authority is to be investigated before choosing production architecture.

## CONFIRMED — world and construction choices 10–17 (2026-11-14)

**Director answered a batch of eight world-design questions:** `10A, 11A, 12B, 13A, 14B ("would be cool"), 15A, 16B, 17A`. Keep **#14 as a preferred experimentation direction**, not a fixed content-generation implementation.

- **#10 A — Large, finite world (confirmed):** each generated world has an explorable extent/boundary rather than expanding infinitely. Actual area, edge presentation, streaming and coordinate scheme are undecided.
- **#11 A — Surface-based terrain deformation (confirmed):** digging/lowering, flattening, raising and shaping land, without an initial requirement for voxel caves, freeform underground tunnels or undercuts. This narrows Decision #9 without selecting a specific terrain representation or depth limit.
- **#12 B — Protect important authored/critical sites (confirmed):** the starting town, relevant other NPC settlements, dungeon entrances and selected special locations should prohibit disruptive player building and terrain alteration as appropriate. Protected footprints/safety margins and possible exceptions remain undecided.
- **#13 A — Build almost anywhere else (confirmed):** outside protected areas, players should be able to select their own workable construction locations across varied terrain, rather than needing designated housing plots. Terrain feasibility, structural mechanics, water placement and permissions remain open.
- **#14 B — Procedurally assembled POIs (preferred to experiment):** director is interested in procedural assembly/variation of dungeons, ruins and other suitable discoverable locations rather than exclusively fixed authored layouts. **The recognizable starting town remains deliberately handcrafted**, and important quests/boss encounters may still require authored components. Decide later which types of POIs use modular/hand-authored rooms versus generated layout, and validate navigability, quality and save identity before a production system.
- **#15 A — New characters start inside the town (confirmed):** first entry should begin in the safe Map1-inspired NPC hub. Rejoining/spawn after death, multiplayer spawn handling, class selection and tutorial behavior remain open.
- **#16 B — Unlockable fast travel (confirmed direction):** fast travel becomes available through exploration/progression, rather than being freely available immediately or relying solely on settlement travel NPCs. Network, destination placement, portal vs NPC mechanism, inventory restrictions and balancing against sailing are not yet decided.
- **#17 A — Partially renewable resources (confirmed):** trees may regrow or be replanted, while valuable ore deposits are generally **finite at each deposit**. Long-lived shared-world access to ores (exploration, alternate sources, etc.) must be evaluated; exact regrowth methods, respawn schedules and ore sources are open.

**Shared implications:** terrain changes and player constructions must persist across save/load and eventual co-op; the protection system must be respected by both building and terrain-edit tools; procedurally generated POIs must not regenerate over existing player/world state. These are design constraints, **not Codex implementation instructions or selected frameworks**.

## CONFIRMED — starting-region spatial principles (2026-11-14)

- Director shared a high-level **Map1-inspired town sketch**, and explicitly clarified that **two black markings represent two paths for entering the town**. They should **not** be interpreted as dark/hostile regions.
- Director endorsed recording **starting-region design principles**: a safe NPC service town, **no player building inside**, first nearby exploration/building possibilities, at least one clear landmark, visually understandable transitions into more dangerous surroundings, and readable directions to travel and gather. The drawn **hill represents a terrain/map boundary**, rather than an approved landmark destination.
- The **bottom-left mark** suggests space for an **optional NPC**, possibly for mounts if that service becomes relevant, or for another NPC. A mount system, mount vendor and exact NPC roster are **not** confirmed.
- The exact map outline, number of buildings, road roles, terrain heights, NPC layout, enemy placement, location of any gates and building-zone boundaries remain **undecided**. **Do not invent a forced survival path vs RPG path division.**
- This design is consistent with the prior choice of an **authored settlement in a generated world**. It is a **design statement, not a Codex task or finalized world geometry**. See `docs/12_STARTING_REGION.md`.

## CONFIRMED — social and professions

- Parties/groups are wanted.
- **No distance/proximity restriction on party character-XP sharing**, including a friend building at the base while another fights elsewhere.
- Friend groups should be able to choose whether they share equally or give more XP to the player doing the killing. **The available mode(s) and actual formula remain to be prototyped.**
- Gathering profession XP should come from personally doing the activity, rather than automatically sharing it like character XP (strong agreed direction in discussion).
- Lightweight “guild/clan” group naming/identity for friends, roleplay, and several guilds within one shared world (e.g., 2–3); not Metin2's ranked, competitive, deep guild system.
- Guild membership and active party are **different concepts**; parties should be allowed across guilds (design direction accepted).
- Begin with a **small profession set**: mining, woodcutting, farming — no need for dozens of skills.

## CONFIRMED — equipment philosophy

- Regular weapon bonuses should be available across **all swords**, regardless of model: e.g. **+20% Damage vs Orcs** could roll on an ordinary sword or a special sword. It would be weird to arbitrarily prevent that bonus on one sword.
- Ordinary weapon base stats can be fixed while different special items can have unique rules for static vs variable stats, distributions, ratios, or relationships.
- **One** VMS/REK-inspired DSS/FKS-style weapon is sufficient as an initial **example/possible item**; perhaps one or two later. It is **one of N items**, **not a central system that defines the game**.
- Desirable rare weapons should be able to remain meaningful for many hours when exceptionally rolled and upgraded.
- Metin2-inspired **+0 to +9 enhancement** and regular item bonus switching are desired progression layers. Details, costs, failures, switching scope, and probabilities are not approved.
- A special DSS/FKS roll is distinct from the shared ordinary bonus pool. The relationship of those two stats and whether/how they reroll is not finalized.

## CONFIRMED — immediate implementation priority

- **First task was movement/camera/controls** to establish a playable graybox foundation. The user playtested the committed 0.01a slice (commit `3feb669`, 2026-11-14) and reported that WASD and mouse camera **feel good**. The lowest step is traversable; two higher steps are not, which is acceptable for now. Preserve the working movement while moving on to combat experiments.
- **Updated priority (2026-11-13): The overall feel of fighting is more important to the game's success than further polishing basic traversal.** After preserving the working first movement slice, experiment with basic combat interaction and feedback **before** spending time on optional jumping/sprint/traversal refinements. Necessary combat mobility (e.g. dodge) can be developed in the context of combat tests.
- Keep combat experiments minimal: simple attack vs target first, then an enemy that can respond, followed by iterations on timing, impact, defensiveness and group fights. Do **not** lock weapon/class skill ownership or full combat architecture yet.
- Decide enemy density/variety, character skill vs weapon skill behavior, gear progression and inventory implementation through later tests rather than overplanning.

## CONFIRMED — revised next development priority (2026-11-14)

- **The director explicitly chose “building and living in a world” as the first gameplay loop to develop and evaluate.** This supersedes the *order* that said combat experiments must come next after movement; it does **not** downgrade combat, loot, classes or RPG progression in the finished game.
- **Interpretation:** the older, confirmed statement that fighting feel matters more than further **optional movement polishing** still stands. It did not imply that building should wait behind combat.
- **Working first playable brief:** gather one wood resource, build a small shelter with connected/snapping pieces, and enter it. This is a **proposed implementation milestone**, not approval of specific tree physics, final building formulas, save/network architecture, a 30-minute content target, or permanent construction rules. See `docs/STATE.md` and `docs/BRIEF_01_SHELTER.md`.
- **Process correction:** user rejected an hour-long capsule/dummy HP smoke test as a meaningful gameplay milestone. Technical correctness belongs in routine automated checks; playtests should focus on actual player experience. Exact optimal Codex task scope remains to be calibrated by outcomes.

## CONFIRMED — development responsibilities and sequence (2026-11-14)

- **Technical correctness is primarily Codex's responsibility** (compilation, automated behavioral checks, Play Mode observations when available); **the director evaluates how gameplay feels** and whether the experience fits Addiction². A user playtest should not be required for arithmetic or the existence of code paths.
- **Broad home/world vision accepted provisionally:** a personally selected, player-constructed home in an explorable world, able to persist and eventually support playing with friends, is the right direction **but not yet a complete or individually approved list of mechanics**. Building system design, terrain interaction and actual home benefits are still open.
- **Development order:** establish building/living/world gameplay first, **then introduce the RPG aspect**; don't construe this as abandoning RPG identity or a decision to finish every survival mechanic before starting combat. Exact order of building, resource gathering, save/load and world generation experiments is still to be reasoned through.
- **Do not auto-launch the existing shelter brief:** it is an unapproved candidate until development strategy and relevant constraints are considered.

## NEW CLARIFICATIONS — architecture discussion (2026-11-13)

- **World/character saves:** Character/world persistence is an important decision, **but not needed in the first movement prototype**. The user explicitly **does not want unrestricted Valheim-style option A** (one character freely taking all equipment/progression between any worlds). **World-bound characters (B)** or a **restricted/configurable hybrid (C)** are candidates. **Reason explicitly confirmed:** unrestricted carry-over of high-level characters/equipment into a fresh friend-group world could immediately destroy the fun and sense of shared progression for the other players; this is a core experience protection, not merely a technical anti-cheat concern. Do **not** choose B vs C without further discussion or playtest; define before serious persistent progression.
- **Item data architecture:** User wants to investigate **separating stat model/stat definitions from item definitions**. Treat separation of immutable item templates, stat/bonus definitions and per-item runtime instances as a strong architectural direction. The exact classes, APIs, stacking order and bonus formulas are not fixed.
- **Character/class code architecture:** User explicitly raised a more professional/modular **class/manager architecture**, and asked about **determinism**. The intended need is clear separation of responsibilities and predictable behavior **at a project scale where tangled systems could become costly to repair**; the user strongly endorses intentionally thinking this through but has **not selected an architecture**. This is **not approval of a specific manager singleton, ECS, netcode library, or deterministic physics implementation**. Investigate composed components/services, data-driven class profiles and independently testable simulation logic.
- **World approach:** User chose a **hybrid direction**: place/design important locations such as the starting town, **generate the surrounding world**. World-gen algorithms, seamless placement, seed handling, dungeon placement and scale remain undecided. This updates the earlier “procedural vs handcrafted?” open question.
- **Building:** User emphasized the **Valheim building system is an important pillar**, not just generic “place one wall.” Its feel and systemic depth deserve a dedicated prototype experiment; exact structural support, snap points, repair, weather/roof behavior and multiplayer ownership are undecided.
- **Immediate work unchanged:** movement/camera/controls first. Architecture guardrails **are not permission to overbuild a framework in Prototype 0.01**.

## DIRECTION / LIKELY, but NOT a final decision

- Character/class skills combined with weapon-specific basic movesets (hybrid) sounds promising; **still untested**.
- Combat might accommodate both Valheim-like dangerous individual encounters and Metin2-like groups/farming spots in different circumstances.
- Underleveled cooperative victories should come from real team synergy, preparation, and player skill — **not simply auto-lowering the dungeon's enemy levels** to the party. Exact co-op scaling remains undecided.
- Shared character XP **equal/full XP as the default** was proposed; the user approved configurability, not a specific percentage.
- Party and guild identity can coexist; possible member list, tags, emblems, permissions later.
- Three professions might get small milestone perks, not big trees.
- Class damage via weapon-type resistances for certain enemies/bosses could help maintain solo balance (bell/fan shaman example).
- Rare equipment grind should add goals without trivializing ordinary crafted gear or forcing +9 to beat content.
- Basic equipment/crafting must remain viable, and the house/base should support independence.

## UNDECIDED — do NOT pretend these are solved

- Character movement weight/speed, walking vs running/sprint input, stamina costs, jumping and dodge form; camera distance/follow/occlusion.
- Character/class skill system vs weapon-tied skills vs hybrid; skill slots, attributes, leveling curve, maximum level, experience sources, and combat scaling.
- Actual class roster (warrior/assassin/shaman/mage were **examples**); exact allowed weapon sets, buffs, damage profiles, and resistance matrix.
- Enemy species/variety/density, group AI vs individual fights, respawns, drops, bosses, dungeon design, exact difficulty, coop scaling and boss layouts.
- Items, inventory layout/weight/slots, armor categories, crafting/loot mix, rarities, bonus count/pools by non-weapon equipment category, stat ranges/probabilities, damage formulas, enhancement failures, reroll mechanics and locking.
- How group XP distribution is configured, whether players can switch freely, percentages, how to deter accidental abuse, how rewards/loot are assigned.
- The number and placement of other settlements; ships and world geography; **specific hybrid generation implementation** (hand-placed important locations plus generated surroundings is the selected direction).
- Mining topology: ore nodes yes as broad idea, but underground excavatable terrain, mines/caves and dedicated mining dungeons are **not committed**.
- Quest volume and narrative, precise number of NPCs, trade economy, reputation, and town mid/late-game services.
- Exact profession progression depth, breakpoints, perk behavior, farming/woodcutting/mining numerical benefits.
- Networking architecture, server model, save implementation, permissions, coop player cap, PvP policy; **persistence option B or C** remains unselected, while unrestricted option A is disfavored/rejected.
- Whether a visual “color bible,” stylization or lighting presets are used later.

## REJECTED / CORRECTED — do not resurrect as constraints

- **“We are building a Valheim mod.”** False. This is an original game.
- **“We combine Valheim, Metin2, and New World equally.”** False. New World is only a small layer on top.
- **“Elden Ring is a progression design target.”** False. It was mentioned only because it has levels.
- **“All or most weapons roll DSS/FKS.”** False. One possible distinctive item among N.
- **“Only the Moonblade can get Orc bonus while ordinary swords cannot.”** False. Ordinary bonuses belong to the broader sword category.
- **“The exact weapon stats, sample probabilities, level bands, or dungeon examples have been approved.”** False. They were illustrative.
- **“Shaman/support is required to complete dungeons.”** False. Support is optional, including for solo players.
- **“Cooperation means strict party requirements or hard level locks.”** False. It helps players overperform **earlier**.
- **“Miner must explore dedicated underground mining dungeons.”** Not decided; the user was unsure.
- **“We need lots of settlements or an MMO guild leaderboard.”** Not requested.
- **“Start implementation with loot, blacksmith, and levels.”** Superseded by **start with controls and movement**.
- **“ChatGPT plugin installation confirms a local Codex plugin.”** It does not; verify both separately.

## Updating this ledger

Use the status categories above, a short dated note, and the reason/evidence (user decision vs playtest result). Do not erase alternatives from the notebook just because they are deferred.
