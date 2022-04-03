PGDMP                         z            CaptActs    10.16    10.16 1    )           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            *           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            +           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false            ,           1262    25050    CaptActs    DATABASE     �   CREATE DATABASE "CaptActs" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Russian_Russia.1251' LC_CTYPE = 'Russian_Russia.1251';
    DROP DATABASE "CaptActs";
             postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
             postgres    false            -           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                  postgres    false    3                        3079    12924    plpgsql 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
    DROP EXTENSION plpgsql;
                  false            .           0    0    EXTENSION plpgsql    COMMENT     @   COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';
                       false    1            �            1259    25179    CaptAct    TABLE     P  CREATE TABLE public."CaptAct" (
    "ID_CaptAct" integer NOT NULL,
    "NumberMK" character(20),
    "DateMK" date,
    "NumberAct" character(20),
    "CaptCats" integer,
    "CaptDogs" integer,
    "CaptAnimals" integer,
    "CaptDate" date,
    "CaptPurpose" character(30),
    "Municipality_ID" integer,
    "OMSU_ID" integer,
    "CaptOrg_ID" integer,
    "Locality_ID" integer,
    CONSTRAINT "CaptAct_CaptAnimals_check" CHECK (("CaptAnimals" >= 0)),
    CONSTRAINT "CaptAct_CaptCats_check" CHECK (("CaptCats" >= 0)),
    CONSTRAINT "CaptAct_CaptDogs_check" CHECK (("CaptDogs" >= 0))
);
    DROP TABLE public."CaptAct";
       public         postgres    false    3            �            1259    25177    CaptAct_ID_CaptAct_seq    SEQUENCE     �   CREATE SEQUENCE public."CaptAct_ID_CaptAct_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public."CaptAct_ID_CaptAct_seq";
       public       postgres    false    197    3            /           0    0    CaptAct_ID_CaptAct_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public."CaptAct_ID_CaptAct_seq" OWNED BY public."CaptAct"."ID_CaptAct";
            public       postgres    false    196            �            1259    25216    CaptOrg    TABLE     V   CREATE TABLE public."CaptOrg" (
    "ID_CaptOrg" integer NOT NULL,
    "Name" text
);
    DROP TABLE public."CaptOrg";
       public         postgres    false    3            �            1259    25214    CaptOrg_ID_CaptOrg_seq    SEQUENCE     �   CREATE SEQUENCE public."CaptOrg_ID_CaptOrg_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public."CaptOrg_ID_CaptOrg_seq";
       public       postgres    false    203    3            0           0    0    CaptOrg_ID_CaptOrg_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public."CaptOrg_ID_CaptOrg_seq" OWNED BY public."CaptOrg"."ID_CaptOrg";
            public       postgres    false    202            �            1259    25227    Locality    TABLE     X   CREATE TABLE public."Locality" (
    "ID_Locality" integer NOT NULL,
    "Name" text
);
    DROP TABLE public."Locality";
       public         postgres    false    3            �            1259    25225    Locality_Locality_seq    SEQUENCE     �   CREATE SEQUENCE public."Locality_Locality_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public."Locality_Locality_seq";
       public       postgres    false    205    3            1           0    0    Locality_Locality_seq    SEQUENCE OWNED BY     X   ALTER SEQUENCE public."Locality_Locality_seq" OWNED BY public."Locality"."ID_Locality";
            public       postgres    false    204            �            1259    25205    Municipality    TABLE     `   CREATE TABLE public."Municipality" (
    "ID_Municipality" integer NOT NULL,
    "Name" text
);
 "   DROP TABLE public."Municipality";
       public         postgres    false    3            �            1259    25203    Municipality_ID_OMSU_seq    SEQUENCE     �   CREATE SEQUENCE public."Municipality_ID_OMSU_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public."Municipality_ID_OMSU_seq";
       public       postgres    false    3    201            2           0    0    Municipality_ID_OMSU_seq    SEQUENCE OWNED BY     c   ALTER SEQUENCE public."Municipality_ID_OMSU_seq" OWNED BY public."Municipality"."ID_Municipality";
            public       postgres    false    200            �            1259    25194    OMSU    TABLE     P   CREATE TABLE public."OMSU" (
    "ID_OMSU" integer NOT NULL,
    "Name" text
);
    DROP TABLE public."OMSU";
       public         postgres    false    3            �            1259    25192    OMSU_ID_OMSU_seq    SEQUENCE     �   CREATE SEQUENCE public."OMSU_ID_OMSU_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public."OMSU_ID_OMSU_seq";
       public       postgres    false    199    3            3           0    0    OMSU_ID_OMSU_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public."OMSU_ID_OMSU_seq" OWNED BY public."OMSU"."ID_OMSU";
            public       postgres    false    198            �
           2604    25182    CaptAct ID_CaptAct    DEFAULT     ~   ALTER TABLE ONLY public."CaptAct" ALTER COLUMN "ID_CaptAct" SET DEFAULT nextval('public."CaptAct_ID_CaptAct_seq"'::regclass);
 E   ALTER TABLE public."CaptAct" ALTER COLUMN "ID_CaptAct" DROP DEFAULT;
       public       postgres    false    197    196    197            �
           2604    25219    CaptOrg ID_CaptOrg    DEFAULT     ~   ALTER TABLE ONLY public."CaptOrg" ALTER COLUMN "ID_CaptOrg" SET DEFAULT nextval('public."CaptOrg_ID_CaptOrg_seq"'::regclass);
 E   ALTER TABLE public."CaptOrg" ALTER COLUMN "ID_CaptOrg" DROP DEFAULT;
       public       postgres    false    202    203    203            �
           2604    25230    Locality ID_Locality    DEFAULT        ALTER TABLE ONLY public."Locality" ALTER COLUMN "ID_Locality" SET DEFAULT nextval('public."Locality_Locality_seq"'::regclass);
 G   ALTER TABLE public."Locality" ALTER COLUMN "ID_Locality" DROP DEFAULT;
       public       postgres    false    205    204    205            �
           2604    25208    Municipality ID_Municipality    DEFAULT     �   ALTER TABLE ONLY public."Municipality" ALTER COLUMN "ID_Municipality" SET DEFAULT nextval('public."Municipality_ID_OMSU_seq"'::regclass);
 O   ALTER TABLE public."Municipality" ALTER COLUMN "ID_Municipality" DROP DEFAULT;
       public       postgres    false    201    200    201            �
           2604    25197    OMSU ID_OMSU    DEFAULT     r   ALTER TABLE ONLY public."OMSU" ALTER COLUMN "ID_OMSU" SET DEFAULT nextval('public."OMSU_ID_OMSU_seq"'::regclass);
 ?   ALTER TABLE public."OMSU" ALTER COLUMN "ID_OMSU" DROP DEFAULT;
       public       postgres    false    199    198    199                      0    25179    CaptAct 
   TABLE DATA               �   COPY public."CaptAct" ("ID_CaptAct", "NumberMK", "DateMK", "NumberAct", "CaptCats", "CaptDogs", "CaptAnimals", "CaptDate", "CaptPurpose", "Municipality_ID", "OMSU_ID", "CaptOrg_ID", "Locality_ID") FROM stdin;
    public       postgres    false    197   �7       $          0    25216    CaptOrg 
   TABLE DATA               9   COPY public."CaptOrg" ("ID_CaptOrg", "Name") FROM stdin;
    public       postgres    false    203   �7       &          0    25227    Locality 
   TABLE DATA               ;   COPY public."Locality" ("ID_Locality", "Name") FROM stdin;
    public       postgres    false    205   �7       "          0    25205    Municipality 
   TABLE DATA               C   COPY public."Municipality" ("ID_Municipality", "Name") FROM stdin;
    public       postgres    false    201   �7                  0    25194    OMSU 
   TABLE DATA               3   COPY public."OMSU" ("ID_OMSU", "Name") FROM stdin;
    public       postgres    false    199   8       4           0    0    CaptAct_ID_CaptAct_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public."CaptAct_ID_CaptAct_seq"', 1, false);
            public       postgres    false    196            5           0    0    CaptOrg_ID_CaptOrg_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public."CaptOrg_ID_CaptOrg_seq"', 1, false);
            public       postgres    false    202            6           0    0    Locality_Locality_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public."Locality_Locality_seq"', 1, false);
            public       postgres    false    204            7           0    0    Municipality_ID_OMSU_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public."Municipality_ID_OMSU_seq"', 1, false);
            public       postgres    false    200            8           0    0    OMSU_ID_OMSU_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public."OMSU_ID_OMSU_seq"', 1, false);
            public       postgres    false    198            �
           2606    25191    CaptAct CaptAct_NumberAct_key 
   CONSTRAINT     c   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_NumberAct_key" UNIQUE ("NumberAct");
 K   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_NumberAct_key";
       public         postgres    false    197            �
           2606    25189    CaptAct CaptAct_NumberMK_key 
   CONSTRAINT     a   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_NumberMK_key" UNIQUE ("NumberMK");
 J   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_NumberMK_key";
       public         postgres    false    197            �
           2606    25187    CaptAct CaptAct_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_pkey" PRIMARY KEY ("ID_CaptAct");
 B   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_pkey";
       public         postgres    false    197            �
           2606    25224    CaptOrg CaptOrg_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public."CaptOrg"
    ADD CONSTRAINT "CaptOrg_pkey" PRIMARY KEY ("ID_CaptOrg");
 B   ALTER TABLE ONLY public."CaptOrg" DROP CONSTRAINT "CaptOrg_pkey";
       public         postgres    false    203            �
           2606    25235    Locality Locality_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public."Locality"
    ADD CONSTRAINT "Locality_pkey" PRIMARY KEY ("ID_Locality");
 D   ALTER TABLE ONLY public."Locality" DROP CONSTRAINT "Locality_pkey";
       public         postgres    false    205            �
           2606    25213    Municipality Municipality_pkey 
   CONSTRAINT     o   ALTER TABLE ONLY public."Municipality"
    ADD CONSTRAINT "Municipality_pkey" PRIMARY KEY ("ID_Municipality");
 L   ALTER TABLE ONLY public."Municipality" DROP CONSTRAINT "Municipality_pkey";
       public         postgres    false    201            �
           2606    25202    OMSU OMSU_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public."OMSU"
    ADD CONSTRAINT "OMSU_pkey" PRIMARY KEY ("ID_OMSU");
 <   ALTER TABLE ONLY public."OMSU" DROP CONSTRAINT "OMSU_pkey";
       public         postgres    false    199            �
           2606    25262    CaptAct CaptAct_CaptOrg_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_CaptOrg_ID_fkey" FOREIGN KEY ("CaptOrg_ID") REFERENCES public."CaptOrg"("ID_CaptOrg") ON UPDATE CASCADE ON DELETE CASCADE;
 M   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_CaptOrg_ID_fkey";
       public       postgres    false    2717    197    203            �
           2606    25267     CaptAct CaptAct_Locality_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_Locality_ID_fkey" FOREIGN KEY ("Locality_ID") REFERENCES public."Locality"("ID_Locality") ON UPDATE CASCADE ON DELETE CASCADE;
 N   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_Locality_ID_fkey";
       public       postgres    false    2719    197    205            �
           2606    25252 $   CaptAct CaptAct_Municipality_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_Municipality_ID_fkey" FOREIGN KEY ("Municipality_ID") REFERENCES public."Municipality"("ID_Municipality") ON UPDATE CASCADE ON DELETE CASCADE;
 R   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_Municipality_ID_fkey";
       public       postgres    false    201    2715    197            �
           2606    25257    CaptAct CaptAct_OMSU_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_OMSU_ID_fkey" FOREIGN KEY ("OMSU_ID") REFERENCES public."OMSU"("ID_OMSU") ON UPDATE CASCADE ON DELETE CASCADE;
 J   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_OMSU_ID_fkey";
       public       postgres    false    199    2713    197                  x������ � �      $      x������ � �      &      x������ � �      "      x������ � �             x������ � �     