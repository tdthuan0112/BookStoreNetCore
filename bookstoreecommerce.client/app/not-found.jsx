import notFoundImg from "@/assets/img/404-page-notfound.png";

import Image from "next/image";

export default function NotFound() {
    return (
        <main className="not-found">
            <h1>Not Found</h1>
            <p>We could not find the requestes page</p>
            <Image src={notFoundImg} with={400} height={400} alt="Page Not Found" />
        </main>
    );
}
