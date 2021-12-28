using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private int maxHealth;
    private int currentHealth;

    public Slider bar;

    public void setMaxHealth(int health) {
        bar.maxValue = health;
        maxHealth = health;
    }

    public void setMinHealth(int health) {
        bar.minValue = health;
    }

    public void setHealth(int health){
        bar.value = health;
        currentHealth = health;
    }

    public int getMaxHealth() {
        return maxHealth;
    }

    public int getCurrentHealth() {
        return currentHealth;
    }

    public void TakeDamage(int damage) {
         if ((currentHealth - damage) < 0){
            currentHealth = 0;
            setHealth(currentHealth);
         } else {
         currentHealth -= damage;

         setHealth(currentHealth);
         }
     }

     public void Heal(int heal) {
         if ((currentHealth + heal) > maxHealth){
            currentHealth = maxHealth;
            setHealth(currentHealth);
         } else {
         currentHealth += heal;

         setHealth(currentHealth);
         }
     }

     public void IncreaseMaxHP(int increase) {
         maxHealth += increase;

         setMaxHealth(maxHealth);
         
     }

     public void DecreaseMaxHP(int decrease) {
         if (maxHealth < 0) {
             maxHealth = 0;
         } else {
             maxHealth -= decrease;
         }

         if (currentHealth > maxHealth) {
             currentHealth = maxHealth;
        }

         setMaxHealth(maxHealth);
     }
}
