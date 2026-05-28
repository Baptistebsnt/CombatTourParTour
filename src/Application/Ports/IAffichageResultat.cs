namespace CombatTourParTour.Application.Ports;

public interface IAffichageResultat
{
    void AfficherVictoire();
    void AfficherDefaite();
    void AfficherEntreVagues(int soin);
}
