# Discussion history / provenance of decisions

**Purpose:** Preserve the evolution of ideas, especially corrections, without promoting assistant speculation to confirmed facts. This is a **faithful thematic digest**, not a verbatim copy of every chat message. The contemporaneous complete conversation remains outside the repo; future chats must treat **this repo's decisions/docs as the working authority**.

**Conversation snapshot:** November 13, 2026.

## 1. Initial idea — Valheim meets Metin2

User proposed a **Map1-inspired town**, NPCs as the differentiating factor, definitely a **blacksmith**, more quests/story, and continued Valheim-like survival/building outside town. The town can start as the player's base, but is not where player construction occurs. Later a player may use their own home and sometimes return to town or discover distant places/ships. Krumpac was an inspirational comparison.

Assistant suggested blacksmith enhancements, merchants/elders/hunters, dynamic quests, balance of world/home/town and distant settlements. **Only chosen essentials were later promoted to the decision ledger.**

## 2. Gathering, levels, grinding and dungeons

User said mining is fun in New World, 7 Days to Die, Rust, Valheim for different reasons; a low-complexity profession tree for mining, woodcutting and farming would be enough. Wanted character levels (Elden Ring mentioned solely because it has them), more dungeons/bosses, more combat and the grind for a favorite Metin2-like item including upgrading. Assistant proposed profession milestones, dungeon mines and level caps as examples.

**Correction:** user said **original game, not a Valheim mod**, and was **unsure about dedicated mines**.

## 3. Underleveled freedom and the chill MMO

User strongly endorsed no dungeon entry level walls: they are exactly the player who would attempt level-30-like content at absurdly low levels and astonish friends. They want the after-work, two-hours-toward-a-weapon feeling, while single-player removes competitive pressure. Friends may have their own dynamics; that's okay. Assistant proposed levels as power, not permission, and a complete finite adventure without MMO obligations. Long-term items can be known before they become obtainable.

## 4. VMS/REK-inspired special stat item

User introduced Vollmondschwert / Roteisenklinge **DSS/FKS** idea and variable item rolls alongside enhancement and bonus switching. They clarified that different items may have fixed/variable stats and different distributions or linked ratios. They also corrected a major misinterpretation:
- Regular +Orcs damage bonus (e.g. +20%) should **not** be reserved to individual sword models: it can appear on **all swords**.
- A DSS/FKS special weapon is only **one or maybe two** weapons to consider; later explicitly reiterated it's **one item of x/N equipment items**, not the equipment system's centrepiece.

Assistant at various points suggested fixed original DSS/FKS rolls, switching them, upgrade costs, item stat tables, sample percentages, ranged bonuses, special weapon identities and feature lists. **No numeric balance values or reroll rules were approved.**

## 5. Move from designing to prototyping; engine selection

User asked to stop planning the whole game and build an ugly playable test. Already knows programming, has Godot installed and Blender MCP configured, hates Unreal, and considered Unity versus Godot. Unity 6.6/6000.6.9f1 was installing partly due to CLI/Codex automation potential.

After tool discussion, Unity chosen for **this prototype**. Two video transcripts showed small-job AI workflows, placeholder characters, tests and iteration. User then challenged earlier rushed design assumptions: **movement/controls/camera must come first**; skill ownership (class/character vs weapon) and comparisons of mob variety, equipment, character and inventory between Valheim and Metin2 should be **decided through tests**, not assumed.

## 6. Classes, support and underleveled co-op

User said classes **yes** (Diablo 4 merely proof that classes can work without an MMO), each with a small appropriate weapon variety. Classes must not restrict building/survival activities. Assistant suggested class skills + weapon moveset hybrid, warrior/assassin/shaman/mage examples. **The actual roster/skill architecture remains undecided.**

**Correction of cooperation interpretation:** user did not mean mandatory party content; they meant **two level ~18–20 friends can use boosts and teamwork to clear a dungeon a solo ~30 character would find reasonable**. Support isn't mandatory, regardless of its exact abilities. Every class can play through the game solo; some boss times can differ. User suggested boss/Metin-stone-type resistances/weapon-specific damage modifiers such as weaker resistance to shaman bell/fan attacks as later balance controls.

User connected co-op classes to survival playstyles: a friend who loves building and running the base might **also** enjoy the support role and enable earlier dungeon attempts — but the builder is never forced into a support class.

## 7. Parties, XP sharing and lightweight guilds

User wanted parties/groups, **distance-independent XP sharing**, and tiny “guild/clan” naming for multiple friend subgroups in one world (roughly 2–3 possible), without Metin2 guild leaderboards or deep systems.

Assistant suggested equal party XP and profession XP earned by actions. User endorsed configurable sharing: a group could choose **equal XP**, or give **more XP to the person doing the killing**, since they are not competing as an MMO. This addresses the builder being left behind.

Guilds are social identity/roleplay rather than mandatory competitive progression; party/co-op can cross guild boundaries.

## 8. Clarified influence hierarchy

User explicitly stated: **Metin2 is the missing piece that complements Valheim; New World profession mechanics are just a topping.** Assistant had previously overrepresented three-way equivalence and was corrected.

## 9. Installation and repository

- Chose Unity 6.6 6000.6.9f1, URP.
- User installed Unity Technologies plugin in ChatGPT.
- Initially codex command not recognized, then Codex CLI installed and reported working.
- unity command not recognized, then installed Unity CLI 1.0.0 with winget; authenticated successfully.
- Pipeline installation initially errored with no Editor/project open.
- User created **Addiction²** Unity project and linked a GitHub repo; Editor showed SampleScene.
- Unity Pipeline **1.0.0 ready** was confirmed by unity pipeline editors; unity command listed Editor command groups.
- An attempted PowerShell command combined cd and codex on one line without separator; correction was to execute separately or use semicolon.
- Local project path **F:\Addiction²\Addiction²**, repository **KevinRabbe/Addictionx2**.
- User asked to preserve **all game/project information in the repository** as the sole source of truth before implementation begins. This documentation set is the response.

## The recurring error to avoid

Assistant suggestions were sometimes stated too strongly and then corrected. **A repeated example is not an approved feature.** Future work must consult the decision ledger and preserve open design choices until tested/explicitly chosen.

## 10. Follow-up: technical decisions we should make before they become expensive (2026-11-13)

After discussing early architecture risks, the user emphasized:
- Character/world persistence **matters later**, not for first movement prototype. Rejected **A**, unrestricted Valheim-like cross-world character/equipment transfer; **B world-bound** or **C restricted hybrid** remain options.
- Suggested **separating the stat model and stat definitions from item definitions** rather than putting everything in one item class.
- Raised whether class implementation should use **managers/proper architecture**, and asked if it should be **deterministic**; exact patterns remain undecided.
- Favored **placing/desiging the starting town and procedurally generating the rest of the world**.
- Explicitly reinforced **Valheim-like building** as an important gameplay system to prototype, not a throwaway decoration feature.
- Agreed with modular input/camera and small architectural experiments while leaving content and balance details open.

A new docs/09_ARCHITECTURE_GUARDRAILS.md records these boundaries and future decision timing; none changes the first task (movement and camera).

## 11. Additional emphasis: protect fresh-world fun and choose architecture deliberately (2026-11-13)

The user clarified that letting a highly progressed character bring gear/progression freely into a fresh friend's world would **immediately ruin the fun the group could have**. This reinforces the objection to unrestricted option A, while keeping B (world-bound) and C (restricted/configurable hybrid) undecided. The concern is protecting fair collaborative progression, not only anti-cheat.

They further stressed that proper separation of item/stat and character/class responsibilities matters **especially because of the project's size**. They want to research and evaluate suitable architecture rather than prematurely choosing a specific manager pattern or deterministic network simulation. Hybrid authored-town/procedural-world direction and Valheim-like building importance were reconfirmed. First action remains graybox movement.

## 12. Prioritize fighting feel over polishing basic movement (2026-11-13)

After the first playable `Prototype_Movement` graybox, Codex reported clean compilation and Play Mode and awaited human playtest. The user said the first step was traversable while the two higher steps were too high, and **WASD and camera movement felt good**. The assistant suggested jumping next, but the user explicitly corrected the priority: **“its more important how fighting general feels then basic movement i would say.”**

Updated order: preserve/review/commit the basic movement implementation, then make small combat-feel experiments (first an attackable dummy; promptly then a responding enemy, to test genuine fight feel) before spending time on standalone jump/sprint/traversal polish. Dodge or similar mobility may be tested inside combat. This is a **priority correction, not a rejection of jumping** or an approved final combat design.

## 13. Combat feel needs 3D animation to be evaluated meaningfully (2026-11-13)

The user challenged the assumption that capsule-only prototyping is enough to assess **fighting feel**: without a 3D model and movement/attack animation, only **some** combat mechanics can be tested. That distinction is accepted. Basic primitive tests remain useful for attack events, hit detection and damage/cooldown logic, but **full subjective combat feel** will require a **rigged and animated humanoid test asset** and eventually a reacting/attacking enemy. The user has *not* approved any particular source/model style, art budget or animation workflow; an inexpensive/test-quality placeholder should precede full custom production. Existing movement/camera playtest feedback remains positive.

## 14. Screenshot/transcript clarification — borrow the method, not the combat style (2026-11-14)

The user provided a screenshot of the example creator's **two-capsules combat debug view** and re-supplied the video transcript. They emphasized that the original author had **his own specific fighting style**, and asked what genuinely transfers to Addiction² from the **prototype screenshot**.

The useful transferable technique is a tiny, easily inspected debug arena with **visible hitboxes, attack phases/timing, hit/miss events, target HP and input state**. The video screenshot also illustrates hitstop, hitstun and buffering, but **those mechanics and the shown frame numbers are observations, not approved design requirements for our game**. The transcript explains that the creator later changed feedback, effects, animation and sound in response to playtests. Distinguish a *testing workflow* from a chosen combat system. The follow-up experiment should uncover Addiction²'s own desired feel, rather than copy the video author's Onimusha-inspired combat.
