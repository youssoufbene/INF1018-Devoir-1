module Devoir1

    // Plus la vitesse de réglage est haute, plus d'automobiles sont produites
    // par heure. La production commence à 221 automobiles par heure pour vitesse 1 et 
    // incrémente de façon linéaire (vitesse 4 produit 4 * 221 = 884 autos/heure).
    // La vitesse 0 ne produit aucun automobile.

    // Par contre, plus la vitesse est haute, plus la probabilité de faute augmente.
    // Voici une table des taux de réussite :

    // Vitesse 0 : 0% de réussite
    // Vitesses 1 à 4 : 100% de réussite
    // Vitesses 5 à 8 : 90% de réussite
    // Vitesse 9 : 80% de réussite
    // Vitesse 10 : 77% de réussite

    // Calculez le taux de réussite pour une vitesse donnée.
let calculateSuccessRate speed =
    match speed with
    | 0 -> 0.0
    | _ when speed >= 1 && speed <= 4 -> 1.0
    | _ when speed >= 5 && speed <= 8 -> 0.9
    | 9 -> 0.8
    | 10 -> 0.77
    | _ -> invalidArg "speed" "La vitesse doit être entre 0 et 10."

    // Calculez le taux de production par heure basé sur la vitesse, en considérant le taux de réussite.
let calculateHourlyProductionRate speed =
    (float speed) * 221.0 * calculateSuccessRate speed

    // Calculez le nombre entier d'automobiles produite par minute. Arrondissez à l'entier inférieur.
let calculateWorkingCarsPerMinute speed =
    calculateHourlyProductionRate speed / 60.0 |> int