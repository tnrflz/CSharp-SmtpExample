### 📧 SMTP Ayarları Açıklamaları

Aşağıdaki değişkenler, SMTP protokolü kullanılarak e-posta göndermek için gerekli temel yapılandırmaları içerir:

- `string smtpServer = "";`  
    Gönderim yapılacak SMTP sunucusunun adresidir.  
    Örnek: `"smtp.gmail.com"` veya `"mail.ornekdomain.com"`.
    
- `int smtpPort = 587;`  
    SMTP sunucusunun kullandığı port numarasıdır.  
    Genellikle `587` (TLS), `465` (SSL) veya `25` kullanılır.
    
- `string smtpUser = "";`  
    SMTP sunucusuna bağlanmak için kullanılacak kullanıcı adıdır (genellikle e-posta adresi).  
    Örnek: `"info@ornekdomain.com"`.
    
- `string smtpPass = "";`  
    SMTP kullanıcısına ait şifredir. SMTP sunucusu bu bilgiyle kimlik doğrulaması yapar.
    

---

### ✉️ Mail İçeriği Ayarları

E-postanın içeriği ve kime gönderileceği ile ilgili bilgiler aşağıdaki değişkenlerde tutulur:

- `string fromEmail = "";`  
    Gönderen e-posta adresidir. Alıcılar bu adresi görür.
    
- `string fromName = "";`  
    Gönderenin adı. E-posta alıcısına bu isim gösterilir.  
    Örnek: `"Adısz Adısz"`.
    
- `string toEmail = "";`  
    Alıcının e-posta adresidir.  
    Örnek: `"destek@ornekdomain.com"`.
    
- `string subject = "Test";`  
    E-postanın konu (subject) başlığıdır.
    
- `string body = "This is a test mail";`  
    E-postanın içeriğini temsil eder. HTML veya düz metin olabilir.
