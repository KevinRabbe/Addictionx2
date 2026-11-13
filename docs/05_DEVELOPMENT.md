# Development environment, tooling and workflow

**Snapshot as actually observed in chat, 2026-11-13.** Do not mistake reported setup for a live check on a different machine.

## Known environment

- **Engine:** Unity Editor **6.6 / 6000.6.9f1**, Windows, Universal 3D/URP project.
- **Unity project title:** Addiction².
- **Local Unity project path:** **F:\Addiction²\Addiction²** (provided by user).
- **GitHub repo:** [KevinRabbe/Addictionx2](https://github.com/KevinRabbe/Addictionx2), private, branch **main** at documentation snapshot.
- **Unity CLI:** installed via Windows winget (package Unity.CLI), version **1.0.0** reported from unity --version.
- **Unity authentication:** succeeded; *never store login email, URLs containing tokens, licenses or secrets here*.
- **Unity Pipeline:** the user ran **unity pipeline editors**; Editor showed **bereit / ready**, Pipeline **1.0.0**, and **unity command** displayed numerous command groups. This is **VERIFIED in the user's last terminal output**.
- **Codex CLI:** working locally, per user's confirmation. **Local Unity plugin installation in Codex has not been explicitly verified** with output from codex plugin list; ChatGPT-side Unity Technologies plugin was shown installed. These are separate integrations.
- **Blender MCP:** user already had Blender MCP server set up; exact server name, capabilities and Codex wiring not verified here. Reserve for later asset tasks.
- **Git:** user says GitHub repository connected to Unity project; remote was inspected through GitHub and contains a Unity project with Assets, Packages, ProjectSettings and a standard Unity .gitignore. A matching **local Git remote/status was not verified** in chat.
- **Unity Assistant:** project UI offered an AI assistant checkbox; suggestion was to leave disabled. Actual state not verified.

## What was actually seen in the Editor

Initial Unity scene (**SampleScene**) contained Main Camera, Directional Light, Global Volume. Assets included Scenes, Settings, TutorialInfo and InputSystem_Actions. Universal Render Pipeline template appears selected. No custom player controller has been implemented or tested in this chat as of the snapshot.

## Verified working commands on user's Windows PowerShell

    unity --version
    unity auth login
    unity pipeline editors
    unity command

Reported output: Unity CLI 1.0.0; Unity Pipeline 1.0.0 running/ready. Pipeline installation command previously failed when no project/editor was open; later **Unity Pipeline was already present and ready**. No need to reinstall it unless a new environment needs it.

## Launch Codex in the RIGHT directory

PowerShell needs separate commands (a prior attempt combined cd and codex incorrectly):

    cd "F:\Addiction²\Addiction²"
    codex

Or:

    cd "F:\Addiction²\Addiction²"; codex

Run from the Unity project root, **not C:\WINDOWS\system32**.

Optional local checks:

    codex --version
    codex plugin list
    git status
    git remote -v
    unity pipeline editors

Do not print/store Unity login redirects, credentials, personal email, keys or local service tokens in this repository.

## ChatGPT plugin vs Codex plugin vs Unity CLI vs MCP

- **ChatGPT Unity plugin:** Unity Technologies plugin installed in ChatGPT UI; helps chat-side Unity workflows.
- **Local Codex CLI and Unity-specific skills/plugin:** independent local installation; verify with codex plugin list; may require Unity's Codex plugin marketplace installation.
- **Unity CLI:** terminal client installed and tested; can communicate with the running Unity Editor via **Pipeline**.
- **Unity MCP:** optional alternative control protocol, closer to Blender MCP. Not required if direct CLI commands work; do not add it reflexively.

Exact official CLI commands and setup can change as tools evolve; consult their current documentation before giving installation steps. Do not treat old assistant command snippets as permanently reliable.

## Version control

The repository has a Unity-appropriate .gitignore: excludes Library/, Temp/, Logs/, UserSettings/, Build/, etc.; does **not** ignore source Assets, Packages or ProjectSettings. Preserve Unity .meta files. GitHub is the single source of truth for **design docs**, but local Unity source and the remote must remain synchronized normally.

**This documentation was authored directly to GitHub.** On the Windows PC, before starting Codex, from the project directory check status and pull safely:

    cd "F:\Addiction²\Addiction²"
    git status
    git pull --ff-only

If git status shows uncommitted edits, do not discard them; commit/stash/reconcile first. If Git remote is not configured or the branches diverge, inspect rather than force-pulling.

## Workflow from the AI game-development examples

- One job in one focused session, each job ends in verifiable test.
- Keep a small repository brief so new agent sessions don't require earlier context.
- Delegate coding/scene automation to Codex, Blender scripting/assets to Blender later; **four AI models aren't a requirement**.
- Re-run relevant Unity compile/import/tests after each change; avoid editing multiple unrelated systems before verification.
- Get gameplay feel right with capsules before models, then visual references/lighting later.
- Never promise that an automation test proves gameplay feels fun — record human playtesting results.
- Prefer small, reversible commits after tested slices, not unreviewed batches.
