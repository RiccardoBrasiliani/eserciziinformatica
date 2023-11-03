<?php
class Pezzo
{
    private $id;
    private $codice;
    private $titolo;

    public function __getid()
    {
        return $this->id; 
    }
    public function __getcodice()
    {
        return $this->codice;
    }
    public function __setcodice($codice)
    {
        $this->codice=$codice; 
    }
    public function __gettitolo()
    {
        return $this->titolo; 
    }
    public function __settitolo($titolo)
    {
        $this->titolo=$titolo; 
    }
    
}
?>