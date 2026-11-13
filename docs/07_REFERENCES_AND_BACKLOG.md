# Reference videos, design inspiration and deferred experiments

These observations were shared as **transcripts or discussion summaries**, not as a mandate to recreate the showcased games. No URLs/titles for the particular videos were established. Record links here if provided later.

## Video 1 — AI-driven snow survival environment, multiple model roles

The transcript described a creator dividing work among multiple models: a planning/decision model, a mechanics/implementation model, and Blender/aesthetics models. The **useful pattern** was:
- One job per fresh session; one job ends with a test; don't prompt an entire game at once.
- First build a playable loop. Several earlier aesthetically convincing projects were never finished because there was no gameplay loop.
- Begin with **simple primitive shapes**; only later replace placeholders via Blender automation and other tools. Blender scripts that create assets can be iterated by changing a parameter/line and re-running.
- Create visual references for a **feeling**, not to copy artwork. Maintain a consistent palette/“color bible” when eventually polishing.
- Expose lighting settings and presets for rapid in-engine experiments; lighting and atmosphere can transform simple geometry.
- Be skeptical of demanding ultra-realistic assets from simple programmatic modeling; stylized, deliberate geometry can be far more feasible.

**Not immediate features:** The video included real-time deformable snow, local 120m updates, footprints painted into a shared texture, wind effects, house/trees/car replacement, meshes from external AI tools, mesh decimation, animation, a starving man and a bear with different detection, house-wall occlusion and tree fade. All are reference examples, **none are required systems for Addiction²**. Snow algorithm details (e.g., sampling hundreds of thousands of heights every frame) are not a project requirement.

## Video 2 — AI-built combat game in Godot, Unity and Unreal

Uploaded transcript described:
- Starting with **capsules attacking other capsules** to get combat mechanics and early timing/impact feel working before models/polish.
- The user's later screenshot of the video's **Day 1 — Godot, 'Two Capsules on a Grid'** shows explicit debug visualization: Light 1 attack frame 8 active, startup **6** / active **3** / recovery **14** / total **23** frames, damage **8**, plus sample **5-frame hitstop**, **18-frame hitstun**, attack buffering and hitbox overlays. **These are visible demonstration values, not the intended statistics for Addiction².** This clarifies that capsules permit substantial timing and interaction playtesting, although they cannot fully evaluate attack poses, sword animation readability and final weapon feel.
- Godot prototype, then Unity iteration with heavier impacts, hit-stop, camera shake, sound and VFX; later Unreal with more visual work and many tests.
- A visually better later engine build **does not prove that engine is intrinsically faster or better**: design and assets were reused, and experience differed.
- Headless workflows, agent work on scenes and compilation/tests, then repeated playtests.
- Reference concept art was used as a visual target to guide environment work.
- “One change at a time, test, then continue” prevented cascading regressions.

The creator reported very different durations across engines (about 8 days for Godot with waits; ~21 hours for Unity; ~37 hours for Unreal), but these are **anecdotal and not controlled measurements**. We selected Unity for current tooling and workflow, not because of a definitive benchmark.

## Other cited design references and their role

- **Valheim:** primary world feel, open-world survival, building, food/preparation, exploration, sailing, co-op, biome/boss progression and crafting reliability.
- **Metin2:** Map1 early town, NPCs, quests, story hooks, classes, combat skills, character level, monster farming, VMS/REK-style special item, DSS/FKS concept, regular bonuses/switchers, +0–+9 enhancements, dungeons and boss farming, social parties/guild labels.
- **New World:** satisfying mining/woodcutting/farming progression, nothing like its full profession list required.
- **Rust / 7 Days to Die:** comparisons for resource/mining satisfaction; deformable terrain NOT approved.
- **Diablo 4:** classes can work in a modern single/co-op action RPG; not a class blueprint.
- **Elden Ring:** only mentioned as an example of a non-MMO with character levels, not an intended level design or combat mandate.
- **Krumpac/Valheim modpack:** showed others are experimenting with NPC/quest-rich Valheim; this project **is not a mod**.

## Deferred experiment backlog — NOT committed scope

- Graybox controller settings/live tuning panel and camera obstacle fading.
- Compare Valheim-like deliberate single foes with Metin2-like grouped farming fights.
- Test whether class skills, weapon skills or hybrid are more enjoyable.
- Try one particularly memorable special-roll weapon among a larger set of normal weapons.
- Test alternate party-XP modes while one person builds and another kills distant enemies.
- Test what building/gathering progression contributes to combat preparation.
- Add blacksmith specialist upgrades without making basic repairs town-dependent.
- Examine rare weapon drop excitement vs stat switching and retention of original rolls.
- Test resource transport/sailing significance when an explorable world exists.
- Experiment with atmospheric lighting and a consistent stylized visual reference **after** prototype proves fun.
- Test whether party/guild naming and multiple social settlements add value when multiplayer is ready.

## Item/stat research that must not become a design requirement

The discussion of Metin2's actual bonus system mentioned ordinary bonus slots 1–5, separately treated slots 6–7, switching tools, item-type bonus pools, and VMS/REK DSS/FKS stat relationships. These are reference details raised in conversation; **the project did not select the original game's seven-slot system, stat caps, probabilities, switching mechanics, or shop-based implementation**. The user specifically corrected the assistant to retain shared regular sword bonuses (such as damage vs Orcs) across all swords, and to treat a DSS/FKS item as just one exceptional weapon among many.

## Research caveat

Previous assistant messages contained claims about exact Metin2 bonus probabilities/stat caps, precise Unity installation commands, and tooling releases. These were conversational references, **not primary-source-verified project requirements**. Verify current external documentation before implementing source-game-accurate numbers or depending on version-specific CLI behavior.
