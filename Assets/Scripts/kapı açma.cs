using UnityEngine;

public class KapiKontrol : MonoBehaviour
{
    public float acilmaHizi = 2f; // Kapının açılma hızı

    private Vector3 kapaliKonum; // Kapının kapalı olduğu konum
    private Vector3 acikKonum; // Kapının açık olduğu konum
    private bool acikMi = false; // Kapının açık olup olmadığını tutan bayrak

    void Start()
    {
        kapaliKonum = transform.position;
        acikKonum = transform.position + new Vector3(0, 2, 0); // Kapının y ekseninde açıldığı varsayılan konum
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!acikMi)
            {
                AcKapi();
            }
            else
            {
                KapatKapi();
            }
        }
    }

    void AcKapi()
    {
        acikMi = true;
        InvokeRepeating("KapiyiAc", 0f, 0.02f);
    }

    void KapatKapi()
    {
        acikMi = false;
        InvokeRepeating("KapiyiKapat", 0f, 0.02f);
    }

    void KapiyiAc()
    {
        transform.position = Vector3.MoveTowards(transform.position, acikKonum, acilmaHizi * Time.deltaTime);

        if (transform.position == acikKonum)
        {
            CancelInvoke("KapiyiAc");
        }
    }

    void KapiyiKapat()
    {
        transform.position = Vector3.MoveTowards(transform.position, kapaliKonum, acilmaHizi * Time.deltaTime);

        if (transform.position == kapaliKonum)
        {
            CancelInvoke("KapiyiKapat");
        }
    }
}