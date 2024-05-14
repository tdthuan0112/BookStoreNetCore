import "@/styles/global.css";

export const metadata = {
  title: "Book Store E-commerce",
  description:
    "Book Store E-commerce is a app created and developed my Thuan Tran.",
};

export default function RootLayout({ children }) {
  return (
    <html lang="en">
      <body>
        <div id="root">{children}</div>
      </body>
    </html>
  );
}
