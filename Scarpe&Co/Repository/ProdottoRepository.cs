using Scarpe_Co.Models;

namespace Scarpe_Co.Repository
{
    public class ProdottoRepository
    {
        public static List<Prodotto> Prodotti { get; } = new List<Prodotto>
        {
            new Prodotto { Id = Guid.NewGuid(), Nome = "Nike Donna ReactX Pegasus 41", Prezzo = 99.99M, Descrizione = "Scarpa da Donna - Aggiornata per utilizzare un'impronta di carbonio inferiore di almeno il 43% e una schiuma ReactX con un ritorno di energia maggiore del 13%, la Nike Donna ReactX Pegasus 41 offre prestazioni migliori sia per te che per il pianeta. La Nike Donna ReactX Pegasus 41 è dotata di due unità Zoom Air separate, una nel tallone che offre ammortizzazione elastica all'impatto e un'altra nell'avampiede per una sensazione elastica durante la transizione dall'atterraggio allo stacco.La larghezza più ampia dell'avampiede e del tallone non solo migliora la stabilità, ma offre più spazio per riporre un'unità Zoom Air più ampia per una maggiore potenza.La tomaia più leggera e traspirante rispetto a prima utilizza la stessa fascia e imbottitura sull'area mediale del modello precedente per una vestibilità sicura ma confortevole.", ImmagineCopertina = "https://images.prodirectsport.com/ProductImages/Main/1017937_Main_1919160.jpg", ImmagineAggiuntiva1 = "https://images.prodirectsport.com/ProductImages/Gallery_1/1017937_Gallery_1_1919161.jpg", ImmagineAggiuntiva2 = "https://images.prodirectsport.com/ProductImages/Gallery_4/1017937_Gallery_4_1919167.jpg"  },
            new Prodotto { Id = Guid.NewGuid(), Nome = "Nike Zegama 2", Prezzo = 129.99M, Descrizione = "Scarpa da Uomo - Aggiornata e migliorata con una suola Vibram Megagrip, la Nike Zegama Trail 2 offre una trazione migliorata dalle rocce bagnate al fango e all'erba, permettendoti di conquistare i terreni più difficili con una scarpa da trail ammortizzata e robusta. La Nike Zegama Trail 2 ora utilizza più o meno la stessa tecnologia di punta della scarpa da corsa d'élite di Nike, l'Ultrafly, meno la piastra in carbonio, ma con una struttura leggermente più robusta progettata meno per la pura velocità e più per il brivido del percorso, la Zegama rende un ottimo corridore quotidiano ammortizzato oltre ad avere il ritmo per il giorno della gara.La schiuma ZoomX attraverso l'intersuola ha un'altezza dello stack maggiore rispetto all'originale per un'ammortizzazione più leggera e più potenza sui sentieri.La tomaia in mesh ingegnerizzato fornisce la resistenza extra necessaria per stabilità su terreni irregolari, mentre la ghetta alla caviglia aiuta a mantenere i detriti all'esterno. Le sovrapposizioni sulla punta aumentano la durata.", ImmagineCopertina = "https://images.prodirectsport.com/ProductImages/Main/1023663_Main_1897612.jpg", ImmagineAggiuntiva1 = "https://images.prodirectsport.com/ProductImages/Gallery_1/1023663_Gallery_1_1897683.jpg", ImmagineAggiuntiva2 = "https://images.prodirectsport.com/ProductImages/Gallery_4/1023663_Gallery_4_1897788.jpg"  },
            new Prodotto { Id = Guid.NewGuid(), Nome = "Nike Invincible 3", Prezzo = 179.99M, Descrizione = "Scarpa da Uomo - Con uno strato profondo di schiuma altamente reattiva che ti spinge in avanti, le Nike ZoomX Invincible Run FK 3 sono scarpe morbide e propulsive ideali per le tue corse quotidiane. Gli aggiornamenti alle Nike ZoomX Invincible Run Flyknit 3 includono una clip sul tallone più precisa e un'intersuola più ampia, tutti concentrati sulla fornitura di maggiore stabilità.Il supporto ottimizzato e l'ammortizzazione posizionata intenzionalmente si combinano con questi aggiornamenti per fornire un supporto elevato e proteggere dagli effetti della pronazione.L'enorme stack di ZoomX sotto i piedi offre una corsa altamente ammortizzata e altamente reattiva che ti farà rimbalzare con facilità per una transizione fluida e una sensazione confortevole.La tomaia in flyknit si è evoluta, con zone di traspirabilità e una struttura resistente e durevole per un fit sicuro e arioso.", ImmagineCopertina = "https://images.prodirectsport.com/ProductImages/Main/1023630_Main_1871945.jpg", ImmagineAggiuntiva1 = "https://images.prodirectsport.com/ProductImages/Gallery_1/1023630_Gallery_1_1871951.jpg", ImmagineAggiuntiva2 = "https://images.prodirectsport.com/ProductImages/Gallery_4/1023630_Gallery_4_1872060.jpg"  }
        };

        public static void AggiungiProdotto(Prodotto prodotto)
        {
            prodotto.Id = Guid.NewGuid();
            Prodotti.Add(prodotto);
        }

        public static void ModificaProdotto(Prodotto prodottoModificato)
        {
            var prodotto = Prodotti.FirstOrDefault(p => p.Id == prodottoModificato.Id);
            if (prodotto != null)
            {
                prodotto.Nome = prodottoModificato.Nome;
                prodotto.Prezzo = prodottoModificato.Prezzo;
                prodotto.Descrizione = prodottoModificato.Descrizione;
                prodotto.ImmagineCopertina = prodottoModificato.ImmagineCopertina;
                prodotto.ImmagineAggiuntiva1 = prodottoModificato.ImmagineAggiuntiva1;
                prodotto.ImmagineAggiuntiva2 = prodottoModificato.ImmagineAggiuntiva2;
            }
        }
    } 
}
