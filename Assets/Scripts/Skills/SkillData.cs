using System;

public class SkillData 
{
    private float cd;
    private float damage;
    private string trigger;

    public float getCD() {
        return cd;
    }

    public float getDamage() {
        return damage;
    }

    public string getTrigger() {
        return trigger;
    }

    public void setCD(float cd) {
        this.cd = cd;
    }

    public void setDamage(float damage) {
        this.damage = damage;
    }

    public void setTrigger(string trigger) {
        this.trigger = trigger;
    }
}
