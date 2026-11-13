# Conversation coverage audit — important concepts vs repository records

**Reviewed:** 2026-11-13  
**Scope:** The full visible project-design and initial Unity/Codex setup conversation leading to the request to preserve the design in GitHub.  
**Method:** Compared each substantive user correction, preference, decision and unresolved choice to the committed docs. This is a **structured fidelity audit**, not a verbatim transcript or independent verification of every assistant claim about other games.

**Verdict:** All major user-originated requirements and corrections are documented. The audit led to small follow-up additions on source-game bonus layers, explicit inventory alternatives, and the distinction between genuine underleveled teamwork and artificially reducing dungeon enemy levels. Numeric examples remain **examples**, not specifications.

## Coverage matrix

Legend: **C** = confirmed by user; **O** = explicitly open; **P** = optional/proposed/reference; **X** = misunderstanding corrected or rejected.

| Conversation topic | Status | Canonical location / preserved meaning |
| --- | --- | --- |
| Original game versus a Valheim mod | **C/X** | 01_VISION, 02_DECISIONS: original title, modpack only a comparison |
| High-level fusion | **C** | 01_VISION: Valheim world/survival **foundation**, Metin2 progression **missing piece**, New World **small profession add-on** |
| “Chill MMO” voluntary after-work grind | **C** | 01_VISION, 03_DESIGN_NOTEBOOK: players can invest in a rare sword or simply build; no MMO pressure |
| Single-player and cooperative friends | **C** | 01_VISION, 02_DECISIONS: both fundamental; group play optional |
| Starting Map1-inspired town and important NPCs | **C** | 01_VISION, 03_DESIGN_NOTEBOOK: Metin2 structure, Valheim atmosphere |
| Definitely a blacksmith | **C** | 02_DECISIONS, 03_DESIGN_NOTEBOOK: one explicitly required NPC |
| No building inside original town | **C** | 02_DECISIONS: established settlement, player's own home outside |
| Town as initial base, later optional return/unlocks | **C** | 01_VISION, 03_DESIGN_NOTEBOOK: useful early, possible later services |
| Other settlements/ships unspecified | **O** | 02_DECISIONS, 03_DESIGN_NOTEBOOK: no assumption of many hubs |
| Valheim-style freedom: house/farm/crafting/sailing | **C** | 01_VISION: a central part of game identity |
| More quests, story, NPC interactions | **C** | 01_VISION, 03_DESIGN_NOTEBOOK: content direction; specifics undecided |
| More bosses/dungeons/repeatable gear grind | **C** | 02_DECISIONS, 03_DESIGN_NOTEBOOK: more fighting/long-term rewards |
| Mining enjoyable across Valheim/New World/Rust/7DTD | **C** | 03_DESIGN_NOTEBOOK: different inspirations separated |
| Mining dungeons or destructible ground | **O** | 02_DECISIONS: user specifically uncertain about “mines” |
| Simple mining/woodcutting/farming progression | **C** | 02_DECISIONS, 03_DESIGN_NOTEBOOK: small set, no 40-skill list |
| Profession perk thresholds and exact yield effects | **P** | 03_DESIGN_NOTEBOOK: milestones/ratios are sample ideas |
| Character levels even outside MMO | **C** | 02_DECISIONS: levels desired; Elden Ring only a quick analogy |
| Fixed level cap/attribute list | **O** | 02_DECISIONS: examples only |
| Classes are wanted | **C** | 02_DECISIONS: class combat identity, small compatible weapon selection likely |
| Exact warrior/assassin/shaman/mage roster | **O/P** | 03_DESIGN_NOTEBOOK: only candidate examples |
| Classes must not restrict building/gathering | **C** | 01_VISION, 02_DECISIONS, AGENTS.md: hard guardrail |
| All classes can solo entire main adventure | **C** | 01_VISION, 02_DECISIONS |
| Different boss completion times for classes | **C** | 02_DECISIONS: permitted, within viable solo balancing |
| Resistances/bell/fan modifiers for shaman balance | **P** | 03_DESIGN_NOTEBOOK: possible balancing tool, numbers not decided |
| Support nice but **never required** | **C** | 02_DECISIONS: co-op boosts without forced healer |
| Builder friend might voluntarily play support | **C/P** | 01_VISION, 03_DESIGN_NOTEBOOK: illustrative social synergy, no class assignment |
| Underleveled dungeon attempts allowed | **C** | 02_DECISIONS: no hard entry gates / automatic miss penalties |
| Level 18–20 party vs comfortable ~30 solo dungeon | **P** | 03_DESIGN_NOTEBOOK: example of earlier clears with real boosts and skill |
| No arbitrary party-level reduction of enemy power | **P** | 02_DECISIONS: suggested non-scaling interpretation, exact tuning undecided |
| Character skills versus weapon skills versus hybrid | **O** | 02_DECISIONS, 03_DESIGN_NOTEBOOK: explicit conflict to experiment on |
| Valheim-like mob variety vs Metin2 farming groups | **O** | 02_DECISIONS, 04_PROTOTYPE: deliberate future experiment |
| Inventory Valheim slots/weight vs Metin2 grid/slots | **O** | 02_DECISIONS, 03_DESIGN_NOTEBOOK: explicit unresolved design comparison |
| Normal swords vs distinct rare weapon identities | **C** | 02_DECISIONS, 03_DESIGN_NOTEBOOK: predictable crafting + interesting exceptions |
| Shared +Orcs bonus on **every** sword | **C/X** | 02_DECISIONS: no arbitrary individual sword exclusions |
| One DSS/FKS-style item among many, not defining all loot | **C/X** | 02_DECISIONS, 03_DESIGN_NOTEBOOK |
| Weapon-specific static, random, weighted, correlated rolls | **C (design capability)** | 02_DECISIONS, 03_DESIGN_NOTEBOOK; exact ranges not agreed |
| VMS and REK as references; Moonblade a placeholder | **P** | 03_DESIGN_NOTEBOOK: no committed item name or art |
| Metin2 1–5 vs 6–7 bonus layers | **P** | 03_DESIGN_NOTEBOOK, 07_REFERENCES_AND_BACKLOG: research context only |
| Enhancement +0 through +9 desired | **C** | 02_DECISIONS: progression layer wanted |
| Switchable regular bonuses desirable | **C** | 02_DECISIONS: exact switching materials/mechanics open |
| DSS/FKS switchability, stat caps and roll odds | **O** | 03_DESIGN_NOTEBOOK: cannot silently implement a claim about original Metin2 |
| Beloved exceptionally rolled early weapon useful for ages | **C** | 01_VISION, 02_DECISIONS |
| Actual upgrade failures/destruction/item locks | **O** | 02_DECISIONS: not chosen; suggestions only |
| Party/group XP irrespective of range | **C** | 02_DECISIONS, 03_DESIGN_NOTEBOOK: distant builder stays in progression loop |
| Group chooses equal or killer-favoured sharing | **C** | 02_DECISIONS: configurable preference; formulas undecided |
| Profession XP earned by doing professions | **C (agreed direction)** | 02_DECISIONS, 03_DESIGN_NOTEBOOK |
| Party may contain different guilds | **C (accepted direction)** | 02_DECISIONS |
| Small guild/clan names, roleplay, 2–3 groups possible | **C/P** | 02_DECISIONS: social identity, counts illustrative |
| No Metin2 guild leaderboards/mandatory ranking | **C** | 02_DECISIONS, 03_DESIGN_NOTEBOOK |
| Start with **ugly movement/camera/controller** prototype | **C** | 02_DECISIONS, 04_PROTOTYPE: explicit implementation order |
| Movement feel via adjustable values; human playtest | **C (method)** | 04_PROTOTYPE: controls first, other systems later |
| Four-AI-model video workflow | **P** | 07_REFERENCES_AND_BACKLOG: one job/test, model count not mandatory |
| Blender MCP, Codex, Unity CLI and GitHub | **C (setup reports)** | 05_DEVELOPMENT: distinguishes verified CLI/editor from unverified local plugins |
| Unity over Godot, not Unreal | **C for prototype** | 02_DECISIONS, 05_DEVELOPMENT |
| Unity 6.6 / URP / Pipeline verified ready | **C (observed)** | 05_DEVELOPMENT: editor, CLI version, pipeline available |
| GitHub repository as working source of truth | **C** | README, AGENTS.md: docs must be updated as decisions change |

## What the audit found worth clarifying

1. **Metin2 bonus-slot layers were discussed but not previously explicitly indexed.** We have now recorded the *reference to* normal bonuses 1–5, separate sixth/seventh bonuses and switching. This is **not** permission to implement all seven slots in our game.
2. **Inventory was mentioned explicitly as a Valheim-vs-Metin2 collision.** The ledger called it undecided already; the design notebook now spells out slots/weight versus grid/equipment-slot alternatives.
3. **Underleveled co-op is about overcoming fixed danger, not “matchmaking scaling.”** This is documented as a likely principle without freezing an enemy-scaling formula.
4. **Documentation completeness is about important user intent, not assistant-generated numerical balance illustrations.** These remain archived as examples where useful and must never be treated as approved.

## Still intentionally not decided

Exact controls, input mapping, camera/stamina/dodge; skill ownership and class roster; damage/resistance tables; monster density; item/inventory UI; crafting, loot and enhancement odds; mob/boss roster; gathering perks; other settlements; procedural world; networking/save architecture; party XP percentages; guild permissions; any original-game IP naming/art. The absence of final values for these subjects is **intentional**.

## Keeping this audit relevant

After a major discussion or design approval:
1. Put the **new decision in docs/02_DECISIONS.md**; don't modify this audit as a substitute for the ledger.
2. If an earlier decision changes, record **why** in docs/06_DISCUSSION_HISTORY.md.
3. Update the relevant design notebook/prototype/development section.
4. Add a traceability row here only if a new major topic arrives or prior coverage was missing.

**Coverage scope caveat:** This is based on the conversation visible for the audit, not hidden reasoning, inaccessible external chats or a verbatim backup of the entire conversation. The full literal chat history is not checked into Git; this repository is a maintained decision/knowledge base.
