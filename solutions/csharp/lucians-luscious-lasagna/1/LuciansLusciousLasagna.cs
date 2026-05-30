class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int remaining_minutes) =>  ExpectedMinutesInOven() - remaining_minutes;
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers) => layers * 2;
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers,int cooking_lasagna) => PreparationTimeInMinutes(layers) + cooking_lasagna;
}
