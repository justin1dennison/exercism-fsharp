module DndCharacter

open System

let random (lower: int) (upper: int): int =
    let r = Random()

    r.Next(lower, upper)

let modifier x =
    float x
    |> fun y -> (y - 10.0) / 2.0
    |> floor
    |> int

let ability() =
    [ 1 .. 4 ]
    |> List.map (fun _ -> random 1 7)
    |> List.sort
    |> List.tail
    |> List.sum


type Character =
    { Strength: int
      Dexterity: int
      Constitution: int
      Intelligence: int
      Wisdom: int
      Charisma: int
      Hitpoints: int }

let createCharacter() =
    let constitution = ability()

    let character: Character =
        { Strength = ability()
          Dexterity = ability()
          Constitution = constitution
          Intelligence = ability()
          Wisdom = ability()
          Charisma = ability()
          Hitpoints = 10 + modifier (constitution) }

    character
