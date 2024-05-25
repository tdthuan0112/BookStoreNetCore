import Image from "next/image";

import welcomeAdminImg from "@/assets/img/welcome-admin.png";

export default function AdminWelcomePage() {
  return (
    <div>
      <Image
        src={welcomeAdminImg}
        width={700}
        height="auto"
        alt="welcome admin image"
      />
    </div>
  );
}
