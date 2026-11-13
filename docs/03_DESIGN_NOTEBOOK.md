# Design notebook — comprehensive capture of ideas and examples

**Nature:** Structured archive of the game-design discussion. **Not a spec.** Numbers, names, level bands, costs and examples in this file are hypothetical unless docs/02_DECISIONS.md explicitly marks them confirmed.

## 1. World structure, Map1, and settlements

### Starting settlement

Metin2 Map1 provides the recognizable **central village structure** and important NPC positions; Valheim provides architecture, atmosphere, immersion and the freedom of an actual survival world. The player starts somewhere established rather than stranded in empty wilderness. The village might include a central square, blacksmith workshop, merchant, village elder, hunter, herbalist, guards, small houses, roads, surrounding forest/ruins, and optionally abandoned mine. **Only the blacksmith and the Map1-inspired starting-village concept were specifically insisted on; the rest are candidate roles.**

The town is the **early-game base**: safe preparation, basic functions, quests, some services and NPCs. Do not allow player-built structures inside it. Players venture out to build homes, workshops, storage, farm, and docks. They return to town for stories, specialist services and potentially mid/late-game unlocks, **not because routine repair should force a long commute**. It is fine if the settlement grows less central later.

Further villages, ports, distant legendary blacksmiths and ships are **possible** future content, not yet needed. We might have one main village plus smaller POIs rather than a settlement per biome. World design may expand naturally with sailing; do not plan all destinations now.

### Player day/example flow (fictional)

Arrive in town; talk to the blacksmith; get a simple quest; explore a forest and establish a small house by a river; grow the house/base; investigate a ruined mine/dungeon; find rare material and visit town for an unlock or enhancement; eventually sail to other places. Spending whole evenings building must stay valid at every stage.

### NPC design

NPCs should be meaningful rather than a crowd of static shops; possible roles include:
- Blacksmith (definitely wanted): equipment enhancements, possible specialist recipes, perhaps quest progression.
- Elder/quest-giver: main story, world context.
- Merchant: trade, supplies.
- Hunter: bounties, monster information.
- Herbalist: gathering/alchemy/food help.

Example hook: aggressive wolves near town lead to a corrupted Metin-stone-like world event; investigating ties combat to story. Exact quests, Metin stones, names and lore are not chosen. Avoid copying protected designs/assets for the eventual original game.

## 2. Survival, building, exploration, and gathering

Survival remains central: resources, crafting, homebuilding, farming, food, preparation, exploration, a dangerous world and eventually ships. Player-built base provides crafting, storage, workshop, farming and social space. No class restrictions on any of it.

### Mining — four inspirations discussed

- Valheim: resource nodes/biome exploration, logistics/transport, pickaxes.
- New World: satisfying profession XP and mastery.
- 7 Days to Die: excavating/creating mines and abundant resources.
- Rust: direct resource harvesting and material value in crafting.

Mining was singled out as fun and important. What to build **first** is a basic satisfying gathering interaction plus progression experiments, not necessarily destructible terrain. Dedicated abandoned mines, underground ore veins, rare minerals, branching tunnels, minibosses or mining dungeons are proposals that the user said they were **unsure** about.

### Small profession system

Start conceptually with **Mining, Woodcutting, Farming** only. Profession XP comes from performing each action. Potential rewards: efficiency, stamina cost, extra yield, rare resource recognition, uncommon material chances, crop improvements. Example mining milestones 5/10/15/20/30/40 were brainstorming, **not level caps or schedules**. Tiny perk choices every ~10 levels were proposed but never confirmed.

These professions should be rewarding for people who already enjoy those activities. Class need not affect mining/woodcutting/farming capability. A combat-focused friend can progress through dungeons while the builder becomes an expert gatherer and creates good food or useful supplies.

### Building/RPG connection

A base supports adventuring via food, materials, repairs, crafting, supplies, organization. Adventuring returns rare materials and loot. Optional gear-enhancement resources might come from mining, combat, bosses, ruins or dungeons; avoid requiring everyone to grind all systems. Some late-game/rare building materials might come from adventures. No profession needs to function like a mandatory MMORPG job.

## 3. Combat, movement and character

### Player controls — the **first** experiment

Begin with a capsule or placeholder in a graybox with simple ground, ramps, stairs and obstacles. Test third-person camera and walking, rotation, running, optional sprinting, jumping, dodge, input interaction and terrain handling. Expose tunable movement speed, acceleration, turning rate, air control, jump characteristics, roll/dash distance, camera distance and smoothing. **These are controls to test, not mechanics all guaranteed to ship.**

### Combat orientation

Potentially mix deliberate, stamina/positioning/animation-conscious Valheim-like combat with Metin2-like skill-based combat against monster groups. Need player hit feedback, telegraphs, block, parry, dodging, stamina, stagger, attacks, special abilities as appropriate — **all later than controller test**. Prototype a training dummy and one enemy before creating dozens of AI behaviors.

Enemy density remains undecided: Valheim-like smaller purposeful encounters, Metin2-like repeatable packs/mob-grind locations, or both depending on regions. One suggested experiment: compare an area with three distinct dangerous enemies against an area of weaker clustered enemies. Boss and dungeon fighting must reward skill, prep and teamwork rather than level gates.

### Levels and classes

A proper character level is desired; level cap 50, attribute list (Strength, Dexterity, Vitality, Intelligence), example perks and XP formulas were **assistant examples, not approved**. Combat XP, quests, bosses and dungeon rewards were suggested. Levels may increase survivability/power but should not produce automatic misses or huge arbitrary damage penalties against higher-level enemies. A great player can beat content much earlier.

Classes: **yes**, with small class-appropriate weapon selection, and **full access to survival gameplay**. Example concepts only:
- Warrior: swords and two-handed weapons, melee/durability.
- Assassin/ninja-like class: daggers/bows/swords, agility.
- Shaman: bells/fans (maybe staffs), buffs/healing/support/magic.
- Mage: magical weapons, spells/area effects.

These names/roster/roles/weapon restrictions are **not locked**. A shaman should solo the game; a support orientation must not mean helpless combat. One possible balance lever is enemy- and boss-specific resistances: some foes take relatively less sword damage and more bell/fan damage. Example resistance percentages were *only illustrative*, and not every class needs equal exact boss clear times.

### Combat skill ownership — an explicit collision to resolve

- **Character/class skills (Metin2-like):** learned on your character, survive weapon swaps where compatible; strong identity and player specialization.
- **Weapon skills:** switching a sword/axe/bow changes actions/abilities, encourages experimentation.
- **Hybrid candidate:** class determines learned skills, weapon defines basic attacks, moveset, reach, timings and compatibility.

No resolution yet. Do not decide the exact meaning of **FKS / skill damage** until we have a working definition of skills in our combat model. This is one of the main systems to prototype after controls.

### Underleveled challenge example

Dungeon balanced for a reasonably equipped level ~30 solo character; level ~18–20 friends, perhaps a warrior and a support shaman, bring strong equipment, buffs, food and skill to clear **earlier**. Even a solo level ~18 specialist should be allowed to attempt it. No invisible dungeon access wall. Those levels are illustrative, not the balancing target.

## 4. Equipment, loot, bonuses and the blacksmith

### Two different directions must coexist

**Predictable survival gear:** normal swords/tools/armor can be crafted from resources with known base properties; enough to progress without excessive rare-drop farming.

**Memorable grind gear:** rare recognizable pieces may drop from specific monsters, zones or dungeons, sometimes with distinctive item-specific variable attributes and long-term enhancement goals. A great early weapon may be worth keeping far beyond its nominal level.

We do **not** want all weapons to be generic five-random-stat color-coded loot. A single special item may be exciting precisely because it behaves differently from numerous normal items.

### Four conceptual layers

1. **Item identity:** base damage, weapon class/type, stamina cost, speed, reach, moveset, art, maybe a unique fixed property.
2. **Item-specific special attributes:** only certain item definitions have these. Some fixed, some random; may have linked ratios or different ranges/weighted distributions.
3. **Regular bonuses:** common eligible pool for equipment categories. **Any sword can have a regular +20% Damage Against Orcs bonus.** Other examples: critical chance, damage against undead, attack speed, stamina efficiency, piercing/stagger/poison chance. Exact pools/categories, number of bonuses and legal combinations are unsettled. Do not invent arbitrary sword-by-sword exclusions.
4. **Enhancement:** proposed +0 through +9, costs/materials/rewards and possibly failures, separated conceptually from rerolling eligible bonuses.

### DSS/FKS and the one special item

Metin2-inspired **DSS (Durchschnittsschaden, average/normal attack damage)** and **FKS (Fertigkeitsschaden, skill damage)** are a useful example of a weapon with **special rolls**. VMS (Vollmondschwert) and REK (Roteisenklinge) were cited as iconic inspirations. One working prototype name was **Moonblade**, but this is a placeholder. **Only ONE such item is envisioned as a starting example; maybe one/two in the future; it is just one of an unspecified number of total items.** It is not what the entire equipment system or first prototype should revolve around.

User observation: some items should have mostly static stats, others different random ranges, probabilities, ratios, or linked bonuses. DSS/FKS-like values could trade off against each other. Example Moonblade with +35 DSS / -12 FKS or +39 DSS / +2 FKS are fake illustrative rolls; no exact distribution was approved.

**Important correction:** early assistant suggested locking original DSS/FKS permanently; then described Metin2's switchers and how original DSS/FKS bonuses might change. **Our own item's reroll rules are UNDECIDED.** No fixed rule from that exchange should be silently implemented. We should later verify actual source-game details independently if exact emulation is considered.

### Bonus switching and upgrade ideas

Ordinary bonus switching at a blacksmith using earned resources seems desirable. Options explored: reroll all bonuses, reroll selected slots, locks to preserve an exceptional stat, switcher materials from activities. These are alternatives, not commitments.

Enhancement from +0 to +9 is desired; example recipes used ore, coins, uncommon minerals, dungeon materials and boss drops. A suggestion was guaranteed low-level upgrades and increasingly costly later upgrades, with no routine destruction of treasured gear. **No failure model, crafting economy or switcher method is yet approved.**

Example item layering (not approved stat lines):
- Iron Sword +6: fixed base, ordinary +Orcs / +Crit / +Undead.
- Moonblade +6: own base and DSS/FKS plus **the same regular sword bonus eligibility**.
- Other future weapons might have static stagger effects, life-steal with item-specific ranges, magical attacks or unique abilities.

### Metin2 equipment-reference details versus our chosen rules

The discussion briefly examined Metin2's **ordinary first five bonuses** and **separately handled sixth/seventh bonuses** as examples of multiple bonus layers. It also discussed reroll/switcher items and bonuses having different pools depending on **equipment slot/category** (weapons vs armor vs jewelry). **This describes the reference-game discussion; we have NOT chosen a 5+2 slot system, switcher design, exact source-game probabilities, or item caps.** Before implementing any claim as faithfully Metin2-like, verify it against current primary sources.

The actual confirmed cross-item rule is more important: **ordinary bonuses such as +20% vs Orcs can roll on every sword**; item-specific DSS/FKS-like mechanics are exceptions limited to specifically designed weapons. Different non-weapon categories may have different pools, but the exact rules remain open.

### Inventory alternatives explicitly raised

The user flagged inventory as an unresolved Valheim-versus-Metin2 design choice. Candidate directions include **Valheim-like inventory slots/weight handling**, **Metin2-like item grid/equipment slots**, or a hybrid. None is approved. Compare after movement/combat tests; avoid prematurely building an elaborate inventory framework.

### Equipment progression philosophy

Survival crafting should remain viable while optional rare-item farming offers a deep long-term goal. A beloved special early weapon with exceptional roll and +9 might remain useful for dozens of hours, but later regions should still introduce genuinely appealing items. The player can farm another drop for a better original roll, farm switching materials, farm enhancement materials, or ignore grinding and build their house.

The blacksmith should provide **a unique reason to return**, without making basic crafting/repair town-only. First design focus is controller, not building these systems.

## 5. Dungeons, enemies, bosses and narrative

More combat, dungeons, repeatable farms, minibosses, major bosses and quests are important. Valheim-like biome/boss milestones could coexist with repeatable Metin2-like dungeon loot goals. Major boss progress may unlock new world capabilities; replayable dungeons can supply equipment, enchantment materials and class/combat XP.

Hypothetical dungeon examples from discussion:
- **Abandoned Mine** (level example 8–15): skeletons/corrupted miners, miniboss, resources and basic materials.
- **Forgotten Crypt** (example 15–25): rooms/traps, boss, rare weapons/upgrade components.
- **Ancient Fortress** (example 25–35): elites/minibosses/boss, advanced equipment.

**These named places, level ranges, drops and mining elements are NOT selected content.** They show how progression could work. More meaningful enemy mechanics, telegraphs and co-op synergy should be tested before building a huge content list.

The game must allow trying these places earlier; levels communicate danger, not access permission.

Narrative approach: NPC → quest → exploration → discovery/combat → world progression, without requiring players to interrupt farming or building every session.

## 6. Co-op, party XP, guilds, and role flexibility

### Parties / group experience

**Required social concept:** A friend can be fighting in the wilderness while another builds at the shared home. In the **same party**, both can share **character XP regardless of physical distance**, so the builder isn't left hopelessly behind. They should decide **how** to share it:
- Equal/full XP for all party members (proposed default).
- More XP for killer / smaller share for others (contribution-focused).
- Maybe more granular custom distribution.

No exact weights, mechanics, consent UI, eligibility constraints or implementation details decided. Group members can be in different guilds. Sharing **profession XP** automatically was not wanted: you become a better miner by mining.

A solo player does not need party functionality. Friends starting at different levels can help each other catch up, and power-leveling is not inherently a competitive-design problem. Multiplayer loot distribution remains undecided.

### Lightweight guilds / clans

The user explicitly wants a **small social feature** for naming friend groups and roleplay, with perhaps **2–3 guilds in one Valheim-like world**, not a competitive Metin2 guild leaderboard. Possible features are name, tag, simple membership list and optionally emblem/access permissions; these latter details are proposals. Guilds persist socially, parties are temporary play groups. No ranked ladder, guild XP requirements, PvP economy or scheduled guild obligations. Multiple parties should be free to assemble across social guild identities.

### Builder + support synergy

A builder/farmer friend could elect a support-oriented class, prepare buffs/food from the base and join a combat-focused friend to tackle dangerous dungeons **early**. But builder ≠ assigned support; any class can build, and even two warriors can cooperate. Solo completion for all classes is a hard goal.

## 7. Balance principles and guardrails

- No automatic hit failures or level-disparity walls against stronger enemies.
- Food, equipment, perks, buffs, skill and co-op can all change effective difficulty.
- Do not layer level bonuses + weapon skills + enchants + food into absurd, mandatory multiplier stacks. Rebalance once real combat exists.
- Different class timings on bosses acceptable; no class completely unable to play through.
- No mandatory healer/support, no dungeon only accessible to a named class.
- No arbitrary requirements such as character level 25 + mining level 30 + blacksmith reputation 15 + three dungeons just to craft one weapon. Avoid progression overload.
- The grind should be **voluntary** and reward incremental progress, not endless chores and artificial FOMO.
- No need for infinite MMO endgame/season schedules; a finite complete adventure can still offer enormous sandbox replay value.

## 7a. Technical architecture clarifications (2026-11-13)

### Persistence: not the prototype bottleneck, but an early real-game decision

The user objects to **option A: unrestricted cross-world transfer of a character's progress and equipment**. Two options remain:
- **B: world-bound characters** — each world tracks its own player progression and items.
- **C: hybrid** — worlds can choose whether/how character progression or items transfer, subject to restrictions.

Both need careful compatibility between player identity, character identity, world identity and save versions. **Do not choose now or implement production saving in the movement prototype.**

### Separating item definition, stat model and item instance

The user explicitly asked whether the **stat model and definition should be separate**. A future proof-of-concept can separate:
- **ItemDefinition**: identifier, item category, base weapon/armor properties, permissible stat families, enhancement capability.
- **StatDefinition / BonusDefinition**: semantic identifier, numeric unit (flat/%), applicability rules, caps if desired, stacking and calculation semantics.
- **ItemInstance**: concrete item UUID, enhancement level, randomly rolled stat values, rolled regular bonuses, durability if applicable.
- **StatCalculation**: deterministic-in-the-mathematical-sense calculation/application of modifiers; independently testable and not tied to UI or drop-roll code.
- **Roll tables**: optional distinct rarity/weighting/relationships per item, separate from stat definitions.

This is an architectural **candidate breakdown**, not named production classes or final stat formulas. It protects the principle that an Orc bonus can appear on all swords and only selected special weapons roll DSS/FKS.

### Class managers versus composition and determinism

User raised a proper class/manager architecture and asked about being deterministic. Favor **clear responsibilities and data-driven class profiles**, without turning everything into one giant manager or overbuilding a service framework. Potential split: class definition/ability eligibility, runtime character state/level, combat action execution, shared survival and gathering, equipment. Class rules should not own building or farming.

**“Deterministic” may refer to more than one thing:** predictable gameplay formulas, repeatable seeded random item/world generation, or fully identical simulation across networked machines. The first two are useful architecture goals. The third is **not automatically provided by Unity physics** and is **not required simply because co-op exists**. Server/host-authoritative game-state handling could be evaluated to avoid relying on lockstep-deterministic physics.

### World: authored settlement in generated wilderness

User likes **both** approaches: a **designed/placed Map1-inspired starting town** integrated into a **procedurally generated surrounding world**. Need later experiments on terrain reservation/flattening or blending around the town, safe location bounds, roads, stable placement, generation seed, loading, terrain changes and saved player-built structures. The “town is a placed location” direction is agreed; its scale/location/presentation and generation technique are not.

### Building is not incidental

The user explicitly highlighted the **Valheim building system** as important. Beyond merely supporting arbitrary cube placement, later tests should assess placement preview and snapping, building pieces, structural integrity/support, terrain interaction, repair/upgrades, ownership/permissions and save/network synchronization. **Those exact mechanics are experiment candidates**, not all confirmed features. Building should remain enjoyable as a long-term playstyle independent of combat class.

## 8. What is deliberately NOT settled

No final world map, biomes, story, architectural style guide, character models, enemy bestiary, town NPC count, dialogue, tech tree, level cap, class list, skill trees, XP percentages, damage numbers, drop probabilities, crafting economy, equipment failure mechanics, inventory format, mining terrain system, ship implementation, additional settlement roster or full multiplayer network design.

See docs/02_DECISIONS.md for the authoritative open-question list.
