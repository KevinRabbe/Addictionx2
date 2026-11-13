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

- **First task was movement/camera/controls** to establish a playable graybox foundation; the user has now playtested this initial slice and reported that WASD and mouse camera **feel good**. It still needs normal review/commit discipline before expanding it.
- **Updated priority (2026-11-13): The overall feel of fighting is more important to the game's success than further polishing basic traversal.** After preserving the working first movement slice, experiment with basic combat interaction and feedback **before** spending time on optional jumping/sprint/traversal refinements. Necessary combat mobility (e.g. dodge) can be developed in the context of combat tests.
- Keep combat experiments minimal: simple attack vs target first, then an enemy that can respond, followed by iterations on timing, impact, defensiveness and group fights. Do **not** lock weapon/class skill ownership or full combat architecture yet.
- Decide enemy density/variety, character skill vs weapon skill behavior, gear progression and inventory implementation through later tests rather than overplanning.

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
