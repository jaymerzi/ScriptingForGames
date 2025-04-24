using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class TriggerParticleEffect : MonoBehaviour
{
    private ParticleSystem particleSystem; // Reference to the Particle System

    public int firstEmissionAmount = 10;
    public int secondEmissionAmount = 20;
    public int thirdEmissionAmount = 30;
    public float delayBetween = 0.5f;

    public int particleAmount = 10; // Exposed variable for particle amount

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>()) // Check if the player triggered the event
        {
            StartCoroutine(EmitParticlesCoroutine()); // Emit the specified amount of particles
        }
    }

    private IEnumerator EmitParticlesCoroutine()
    {
        particleSystem.Emit(firstEmissionAmount);
        yield return new WaitForSeconds(delayBetween);

        particleSystem.Emit(secondEmissionAmount);
        yield return new WaitForSeconds(delayBetween);

        particleSystem.Emit(thirdEmissionAmount);
    }

}