### UI

chat-manager-max-message-length = Your message exceeds {$maxMessageLength} character limit
chat-manager-ooc-chat-enabled-message = OOC chat has been enabled.
chat-manager-ooc-chat-disabled-message = OOC chat has been disabled.
chat-manager-looc-chat-enabled-message = LOOC chat has been enabled.
chat-manager-looc-chat-disabled-message = LOOC chat has been disabled.
chat-manager-dead-looc-chat-enabled-message = Dead players can now use LOOC.
chat-manager-dead-looc-chat-disabled-message = Dead players can no longer use LOOC.
chat-manager-crit-looc-chat-enabled-message = Crit players can now use LOOC.
chat-manager-crit-looc-chat-disabled-message = Crit players can no longer use LOOC.
chat-manager-admin-ooc-chat-enabled-message = Admin OOC chat has been enabled.
chat-manager-admin-ooc-chat-disabled-message = Admin OOC chat has been disabled.

chat-manager-max-message-length-exceeded-message = Your message exceeded {$limit} character limit
chat-manager-no-headset-on-message = You don't have a headset on!
chat-manager-no-radio-key = No radio key specified!
chat-manager-no-such-channel = There is no channel with key '{$key}'!
chat-manager-whisper-headset-on-message = You can't whisper on the radio!

chat-manager-server-wrap-message = [bold]{$message}[/bold]
chat-manager-sender-announcement-wrap-message = [font size=14][bold]{$sender} Announcement:[/font][font size=12]
                                                {$message}[/bold][/font]
chat-manager-entity-say-wrap-message = {$entityName} {$verb}, [font={$fontType} size={$fontSize}]"{$message}"[/font]
chat-manager-entity-say-bold-wrap-message = {$entityName} {$verb}, [font={$fontType} size={$fontSize}][bold]"{$message}"[/bold][/font]

chat-manager-entity-whisper-wrap-message = [font size=11][italic]{$entityName} whispers, "{$message}"[/italic][/font]
chat-manager-entity-whisper-unknown-wrap-message = [font size=11][italic]Someone whispers, "{$message}"[/italic][/font]

# THE() is not used here because the entity and its name can technically be disconnected if a nameOverride is passed...
chat-manager-entity-me-wrap-message = [italic]{ PROPER($entity) ->
    *[false] the {$entityName} {$message}[/italic]
     [true] {$entityName} {$message}[/italic]
    }

chat-manager-entity-looc-wrap-message = LOOC: {$entityName}: {$message}
chat-manager-send-ooc-wrap-message = OOC: {$playerName}: {$message}
chat-manager-send-ooc-patron-wrap-message = OOC: [color={$patronColor}]{$playerName}[/color]: {$message}

chat-manager-send-dead-chat-wrap-message = {$deadChannelName}: {$playerName}: {$message}
chat-manager-send-admin-dead-chat-wrap-message = {$adminChannelName}: ({$userName}): {$message}
chat-manager-send-admin-chat-wrap-message = {$adminChannelName}: {$playerName}: {$message}
chat-manager-send-admin-announcement-wrap-message = {$adminChannelName}: {$message}

chat-manager-send-hook-ooc-wrap-message = OOC: (D){$senderName}: {$message}

chat-manager-dead-channel-name = DEAD
chat-manager-admin-channel-name = ADMIN

chat-manager-rate-limited = You are sending messages too quickly!
chat-manager-rate-limit-admin-announcement = Player { $player } breached chat rate limits. Watch them if this is a regular occurence.

## Speech verbs for chat

chat-speech-verb-suffix-exclamation = !
chat-speech-verb-suffix-exclamation-strong = !!
chat-speech-verb-suffix-question = ?
chat-speech-verb-suffix-stutter = -
chat-speech-verb-suffix-mumble = ..

chat-speech-verb-default = says
chat-speech-verb-exclamation = exclaims
chat-speech-verb-exclamation-strong = yells
chat-speech-verb-question = asks
chat-speech-verb-stutter = stutters
chat-speech-verb-mumble = mumbles

chat-speech-verb-insect-1 = chitters
chat-speech-verb-insect-2 = chirps
chat-speech-verb-insect-3 = clicks

chat-speech-verb-winged-1 = flutters
chat-speech-verb-winged-2 = flaps
chat-speech-verb-winged-3 = buzzes

chat-speech-verb-slime-1 = sloshes
chat-speech-verb-slime-2 = burbles
chat-speech-verb-slime-3 = oozes

chat-speech-verb-plant-1 = rustles
chat-speech-verb-plant-2 = sways
chat-speech-verb-plant-3 = creaks

chat-speech-verb-robotic-1 = states
chat-speech-verb-robotic-2 = beeps

chat-speech-verb-reptilian-1 = hisses
chat-speech-verb-reptilian-2 = snorts
chat-speech-verb-reptilian-3 = huffs

chat-speech-verb-skeleton-1 = rattles
chat-speech-verb-skeleton-2 = clacks
chat-speech-verb-skeleton-3 = gnashes

chat-speech-verb-canine-1 = barks
chat-speech-verb-canine-2 = woofs
chat-speech-verb-canine-3 = howls

chat-speech-verb-small-mob-1 = squeaks
chat-speech-verb-small-mob-2 = pieps

chat-speech-verb-large-mob-1 = roars
chat-speech-verb-large-mob-2 = growls

chat-speech-verb-monkey-1 = chimpers
chat-speech-verb-monkey-2 = screeches

chat-speech-verb-cluwne-1 = giggles
chat-speech-verb-cluwne-2 = guffaws
chat-speech-verb-cluwne-3 = laughs

chat-speech-verb-ghost-1 = complains
chat-speech-verb-ghost-2 = breathes
chat-speech-verb-ghost-3 = hums
chat-speech-verb-ghost-4 = mutters
