/** @type {import('next').NextConfig} */
const nextConfig = {
  //   output: "export", // Outputs a Single-Page Application (SPA).
  distDir: "./dist", // Changes the build output directory to `./dist/`.
  // eslint-disable-next-line no-undef
  //basePath: process.env.NEXT_PUBLIC_BASE_PATH
  images: {
    remotePatterns: [
      {
        protocol: "https",
        hostname: "m.media-amazon.com",
        port: "",
        pathname: "/**",
      },
    ],
  },
};

export default nextConfig;
