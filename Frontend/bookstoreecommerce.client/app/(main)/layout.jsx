import MainHeader from "@/components/header-footer/main-header";
import MainFooter from "@/components/header-footer/main-footer";

export default function MainLayout({ children }) {
  return (
    <>
      <MainHeader />
      {children}
      <MainFooter />
    </>
  );
}
