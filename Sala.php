<?php
class Sala {
    private $conn;
    private $id;
    private $codice;
    private $nome ;
    private $capienza; 

    private function __getid()
    {
        return $this->id;
    }
    public function __getcodice()
    {
        return $this->codice;
    }
    public function __setcodice($codice)
    {
        $this->codice = $codice;
    }
    public function __getnome()
    {
        return $this->nome;
    }
    public function __setnome($nome)
    {
        $this->nome = $nome;
    }
    public function __getapienza()
    {
        return $this->capienza;
    }
    public function __setapienza($capienza)
    {
        $this->capienza = $capienza;
    }
  
    public static function getUltimoSalaId()
    {
        DbManager::initialize("localhost", "concerto", "file.txt");

        $query = "SELECT MAX(id) as ultimo_id FROM sale";

        try {
            $stmt = DbManager::getPdo()->prepare($query);
            $stmt->execute();
            $sala = $stmt->fetch(PDO::FETCH_ASSOC);

            if ($sala) 
            {
                return $sala['ultimo_id'];

            } else {
                return null;
            }
        } catch (PDOException $e) {
            die("\nErrore': " . $e->getMessage());
        }
    }
}
?>
