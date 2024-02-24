public float temperatureNormal = 36.6f;
public float temperatureCritical = 34f;
public float freezeSpeed = 0.05f;
float freezeDamageTimer = 1;
public float freezeDamageDelay = 2;

void Update()
{
    // Температура постоянно убывает с указанной скоростью
    temperatureCurrent -= freezeSpeed * Time.deltaTime;

    // Если температура тела упала ниже критической
    if (temperatureCurrent <= temperatureCritical)
    {
        if (freezeDamageTimer <= 0)
        {
            health.TakeDamage(playerDamage);
            freezeDamageTimer += freezeDamageDelay;
        }
        else
        {
            freezeDamageTimer -= Time.deltaTime;
        }
    }
}
}