import MainHeader from "@/components/header-footer/main-header";
import MainFooter from "@/components/header-footer/main-footer";

export default function AdminDashBoardLayout({ children }) {
  return (
    <>
      <MainHeader />
      <div style={{ minHeight: "600px", backgroundColor: "#F4F4F4" }}>
        {children}
      </div>
      <MainFooter />
    </>
  );
}
