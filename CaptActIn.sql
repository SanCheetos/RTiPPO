PGDMP     5    ;                z         	   CaptActIn    13.6    13.6 Z    -           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            .           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            /           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            0           1262    16394 	   CaptActIn    DATABASE     h   CREATE DATABASE "CaptActIn" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "CaptActIn";
                postgres    false            ?            1259    16395    Action    TABLE     l   CREATE TABLE public."Action" (
    "ID_Action" integer NOT NULL,
    "ActionName" character(20) NOT NULL
);
    DROP TABLE public."Action";
       public         heap    postgres    false            ?            1259    16398    Action_ID_Action_seq    SEQUENCE     ?   CREATE SEQUENCE public."Action_ID_Action_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."Action_ID_Action_seq";
       public          postgres    false    200            1           0    0    Action_ID_Action_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public."Action_ID_Action_seq" OWNED BY public."Action"."ID_Action";
          public          postgres    false    201            ?            1259    16400    CaptAct    TABLE     Z  CREATE TABLE public."CaptAct" (
    "ID_CaptAct" integer NOT NULL,
    "NumberMK" character(20) NOT NULL,
    "DateMK" date NOT NULL,
    "NumberAct" character(20),
    "CaptCats" integer,
    "CaptDogs" integer,
    "CaptAnimals" integer,
    "CaptDate" date,
    "CaptPurpose" character(30),
    "OMSU_ID" integer,
    "CaptOrg_ID" integer,
    "Locality_ID" integer,
    "File_ID" integer,
    CONSTRAINT "CaptAct_CaptAnimals_check" CHECK (("CaptAnimals" >= 0)),
    CONSTRAINT "CaptAct_CaptCats_check" CHECK (("CaptCats" >= 0)),
    CONSTRAINT "CaptAct_CaptDogs_check" CHECK (("CaptDogs" >= 0))
);
    DROP TABLE public."CaptAct";
       public         heap    postgres    false            ?            1259    16406    CaptAct_ID_CaptAct_seq    SEQUENCE     ?   CREATE SEQUENCE public."CaptAct_ID_CaptAct_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public."CaptAct_ID_CaptAct_seq";
       public          postgres    false    202            2           0    0    CaptAct_ID_CaptAct_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public."CaptAct_ID_CaptAct_seq" OWNED BY public."CaptAct"."ID_CaptAct";
          public          postgres    false    203            ?            1259    16408    CaptOrg    TABLE     V   CREATE TABLE public."CaptOrg" (
    "ID_CaptOrg" integer NOT NULL,
    "Name" text
);
    DROP TABLE public."CaptOrg";
       public         heap    postgres    false            ?            1259    16414    CaptOrg_ID_CaptOrg_seq    SEQUENCE     ?   CREATE SEQUENCE public."CaptOrg_ID_CaptOrg_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public."CaptOrg_ID_CaptOrg_seq";
       public          postgres    false    204            3           0    0    CaptOrg_ID_CaptOrg_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public."CaptOrg_ID_CaptOrg_seq" OWNED BY public."CaptOrg"."ID_CaptOrg";
          public          postgres    false    205            ?            1259    16416    File    TABLE     ~   CREATE TABLE public."File" (
    "ID" bigint NOT NULL,
    "Name" character varying(50),
    "Path" character varying(100)
);
    DROP TABLE public."File";
       public         heap    postgres    false            ?            1259    16419    Function    TABLE     i   CREATE TABLE public."Function" (
    "ID_Function" integer NOT NULL,
    "FunctionName" character(40)
);
    DROP TABLE public."Function";
       public         heap    postgres    false            ?            1259    16422    Function_ID_Function_seq    SEQUENCE     ?   CREATE SEQUENCE public."Function_ID_Function_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public."Function_ID_Function_seq";
       public          postgres    false    207            4           0    0    Function_ID_Function_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public."Function_ID_Function_seq" OWNED BY public."Function"."ID_Function";
          public          postgres    false    208            ?            1259    16424    Locality    TABLE     X   CREATE TABLE public."Locality" (
    "ID_Locality" integer NOT NULL,
    "Name" text
);
    DROP TABLE public."Locality";
       public         heap    postgres    false            ?            1259    16430    Locality_ID_Locality_seq    SEQUENCE     ?   CREATE SEQUENCE public."Locality_ID_Locality_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public."Locality_ID_Locality_seq";
       public          postgres    false    209            5           0    0    Locality_ID_Locality_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public."Locality_ID_Locality_seq" OWNED BY public."Locality"."ID_Locality";
          public          postgres    false    210            ?            1259    16432    Log    TABLE     ?   CREATE TABLE public."Log" (
    "ID_Log" integer NOT NULL,
    "User_ID" integer NOT NULL,
    "Action_ID" integer NOT NULL,
    "ActionDate" timestamp without time zone NOT NULL,
    "CaptAct_String" character varying
);
    DROP TABLE public."Log";
       public         heap    postgres    false            ?            1259    16435    Log_ID_Log_seq    SEQUENCE     ?   CREATE SEQUENCE public."Log_ID_Log_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public."Log_ID_Log_seq";
       public          postgres    false    211            6           0    0    Log_ID_Log_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public."Log_ID_Log_seq" OWNED BY public."Log"."ID_Log";
          public          postgres    false    212            ?            1259    16437    Municipality    TABLE     `   CREATE TABLE public."Municipality" (
    "ID_Municipality" integer NOT NULL,
    "Name" text
);
 "   DROP TABLE public."Municipality";
       public         heap    postgres    false            ?            1259    16443     Municipality_ID_Municipality_seq    SEQUENCE     ?   CREATE SEQUENCE public."Municipality_ID_Municipality_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 9   DROP SEQUENCE public."Municipality_ID_Municipality_seq";
       public          postgres    false    213            7           0    0     Municipality_ID_Municipality_seq    SEQUENCE OWNED BY     k   ALTER SEQUENCE public."Municipality_ID_Municipality_seq" OWNED BY public."Municipality"."ID_Municipality";
          public          postgres    false    214            ?            1259    16445    OMSU    TABLE     x   CREATE TABLE public."OMSU" (
    "ID_OMSU" integer NOT NULL,
    "Name" text,
    "Municipality_ID" integer NOT NULL
);
    DROP TABLE public."OMSU";
       public         heap    postgres    false            ?            1259    16451    OMSU_ID_OMSU_seq    SEQUENCE     ?   CREATE SEQUENCE public."OMSU_ID_OMSU_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public."OMSU_ID_OMSU_seq";
       public          postgres    false    215            8           0    0    OMSU_ID_OMSU_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public."OMSU_ID_OMSU_seq" OWNED BY public."OMSU"."ID_OMSU";
          public          postgres    false    216            ?            1259    16453    Role    TABLE     ?   CREATE TABLE public."Role" (
    "ID_Role" integer NOT NULL,
    "RoleName" character(70),
    "Function_ID" integer NOT NULL,
    "Access" character(70) DEFAULT 'все записи'::bpchar NOT NULL
);
    DROP TABLE public."Role";
       public         heap    postgres    false            ?            1259    16456    Role_ID_Role_seq    SEQUENCE     ?   CREATE SEQUENCE public."Role_ID_Role_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public."Role_ID_Role_seq";
       public          postgres    false    217            9           0    0    Role_ID_Role_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public."Role_ID_Role_seq" OWNED BY public."Role"."ID_Role";
          public          postgres    false    218            ?            1259    16458    User    TABLE     ?   CREATE TABLE public."User" (
    "ID_User" integer NOT NULL,
    "Login" character varying(50) NOT NULL,
    "Password" character varying(25) NOT NULL,
    "Role_ID" integer NOT NULL,
    "OMSU_ID" integer,
    "CaptOrg_ID" integer
);
    DROP TABLE public."User";
       public         heap    postgres    false            ?            1259    16461    User_ID_User_seq    SEQUENCE     ?   CREATE SEQUENCE public."User_ID_User_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public."User_ID_User_seq";
       public          postgres    false    219            :           0    0    User_ID_User_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public."User_ID_User_seq" OWNED BY public."User"."ID_User";
          public          postgres    false    220            a           2604    16463    Action ID_Action    DEFAULT     z   ALTER TABLE ONLY public."Action" ALTER COLUMN "ID_Action" SET DEFAULT nextval('public."Action_ID_Action_seq"'::regclass);
 C   ALTER TABLE public."Action" ALTER COLUMN "ID_Action" DROP DEFAULT;
       public          postgres    false    201    200            b           2604    16464    CaptAct ID_CaptAct    DEFAULT     ~   ALTER TABLE ONLY public."CaptAct" ALTER COLUMN "ID_CaptAct" SET DEFAULT nextval('public."CaptAct_ID_CaptAct_seq"'::regclass);
 E   ALTER TABLE public."CaptAct" ALTER COLUMN "ID_CaptAct" DROP DEFAULT;
       public          postgres    false    203    202            f           2604    16465    CaptOrg ID_CaptOrg    DEFAULT     ~   ALTER TABLE ONLY public."CaptOrg" ALTER COLUMN "ID_CaptOrg" SET DEFAULT nextval('public."CaptOrg_ID_CaptOrg_seq"'::regclass);
 E   ALTER TABLE public."CaptOrg" ALTER COLUMN "ID_CaptOrg" DROP DEFAULT;
       public          postgres    false    205    204            g           2604    16466    Function ID_Function    DEFAULT     ?   ALTER TABLE ONLY public."Function" ALTER COLUMN "ID_Function" SET DEFAULT nextval('public."Function_ID_Function_seq"'::regclass);
 G   ALTER TABLE public."Function" ALTER COLUMN "ID_Function" DROP DEFAULT;
       public          postgres    false    208    207            h           2604    16467    Locality ID_Locality    DEFAULT     ?   ALTER TABLE ONLY public."Locality" ALTER COLUMN "ID_Locality" SET DEFAULT nextval('public."Locality_ID_Locality_seq"'::regclass);
 G   ALTER TABLE public."Locality" ALTER COLUMN "ID_Locality" DROP DEFAULT;
       public          postgres    false    210    209            i           2604    16468 
   Log ID_Log    DEFAULT     n   ALTER TABLE ONLY public."Log" ALTER COLUMN "ID_Log" SET DEFAULT nextval('public."Log_ID_Log_seq"'::regclass);
 =   ALTER TABLE public."Log" ALTER COLUMN "ID_Log" DROP DEFAULT;
       public          postgres    false    212    211            j           2604    16469    Municipality ID_Municipality    DEFAULT     ?   ALTER TABLE ONLY public."Municipality" ALTER COLUMN "ID_Municipality" SET DEFAULT nextval('public."Municipality_ID_Municipality_seq"'::regclass);
 O   ALTER TABLE public."Municipality" ALTER COLUMN "ID_Municipality" DROP DEFAULT;
       public          postgres    false    214    213            k           2604    16470    OMSU ID_OMSU    DEFAULT     r   ALTER TABLE ONLY public."OMSU" ALTER COLUMN "ID_OMSU" SET DEFAULT nextval('public."OMSU_ID_OMSU_seq"'::regclass);
 ?   ALTER TABLE public."OMSU" ALTER COLUMN "ID_OMSU" DROP DEFAULT;
       public          postgres    false    216    215            l           2604    16471    Role ID_Role    DEFAULT     r   ALTER TABLE ONLY public."Role" ALTER COLUMN "ID_Role" SET DEFAULT nextval('public."Role_ID_Role_seq"'::regclass);
 ?   ALTER TABLE public."Role" ALTER COLUMN "ID_Role" DROP DEFAULT;
       public          postgres    false    218    217            n           2604    16472    User ID_User    DEFAULT     r   ALTER TABLE ONLY public."User" ALTER COLUMN "ID_User" SET DEFAULT nextval('public."User_ID_User_seq"'::regclass);
 ?   ALTER TABLE public."User" ALTER COLUMN "ID_User" DROP DEFAULT;
       public          postgres    false    220    219                      0    16395    Action 
   TABLE DATA           =   COPY public."Action" ("ID_Action", "ActionName") FROM stdin;
    public          postgres    false    200   ?j                 0    16400    CaptAct 
   TABLE DATA           ?   COPY public."CaptAct" ("ID_CaptAct", "NumberMK", "DateMK", "NumberAct", "CaptCats", "CaptDogs", "CaptAnimals", "CaptDate", "CaptPurpose", "OMSU_ID", "CaptOrg_ID", "Locality_ID", "File_ID") FROM stdin;
    public          postgres    false    202   ?j                 0    16408    CaptOrg 
   TABLE DATA           9   COPY public."CaptOrg" ("ID_CaptOrg", "Name") FROM stdin;
    public          postgres    false    204   ?k                 0    16416    File 
   TABLE DATA           6   COPY public."File" ("ID", "Name", "Path") FROM stdin;
    public          postgres    false    206   5l                 0    16419    Function 
   TABLE DATA           C   COPY public."Function" ("ID_Function", "FunctionName") FROM stdin;
    public          postgres    false    207   Rl                 0    16424    Locality 
   TABLE DATA           ;   COPY public."Locality" ("ID_Locality", "Name") FROM stdin;
    public          postgres    false    209   ?l       !          0    16432    Log 
   TABLE DATA           a   COPY public."Log" ("ID_Log", "User_ID", "Action_ID", "ActionDate", "CaptAct_String") FROM stdin;
    public          postgres    false    211   ?l       #          0    16437    Municipality 
   TABLE DATA           C   COPY public."Municipality" ("ID_Municipality", "Name") FROM stdin;
    public          postgres    false    213   m       %          0    16445    OMSU 
   TABLE DATA           F   COPY public."OMSU" ("ID_OMSU", "Name", "Municipality_ID") FROM stdin;
    public          postgres    false    215   om       '          0    16453    Role 
   TABLE DATA           P   COPY public."Role" ("ID_Role", "RoleName", "Function_ID", "Access") FROM stdin;
    public          postgres    false    217   ?m       )          0    16458    User 
   TABLE DATA           d   COPY public."User" ("ID_User", "Login", "Password", "Role_ID", "OMSU_ID", "CaptOrg_ID") FROM stdin;
    public          postgres    false    219   ?n       ;           0    0    Action_ID_Action_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."Action_ID_Action_seq"', 5, true);
          public          postgres    false    201            <           0    0    CaptAct_ID_CaptAct_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public."CaptAct_ID_CaptAct_seq"', 45, true);
          public          postgres    false    203            =           0    0    CaptOrg_ID_CaptOrg_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public."CaptOrg_ID_CaptOrg_seq"', 3, true);
          public          postgres    false    205            >           0    0    Function_ID_Function_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."Function_ID_Function_seq"', 2, true);
          public          postgres    false    208            ?           0    0    Locality_ID_Locality_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."Locality_ID_Locality_seq"', 3, true);
          public          postgres    false    210            @           0    0    Log_ID_Log_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public."Log_ID_Log_seq"', 34, true);
          public          postgres    false    212            A           0    0     Municipality_ID_Municipality_seq    SEQUENCE SET     P   SELECT pg_catalog.setval('public."Municipality_ID_Municipality_seq"', 3, true);
          public          postgres    false    214            B           0    0    OMSU_ID_OMSU_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public."OMSU_ID_OMSU_seq"', 8, true);
          public          postgres    false    216            C           0    0    Role_ID_Role_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public."Role_ID_Role_seq"', 12, true);
          public          postgres    false    218            D           0    0    User_ID_User_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public."User_ID_User_seq"', 4, true);
          public          postgres    false    220            p           2606    16474    Action Action_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public."Action"
    ADD CONSTRAINT "Action_pkey" PRIMARY KEY ("ID_Action");
 @   ALTER TABLE ONLY public."Action" DROP CONSTRAINT "Action_pkey";
       public            postgres    false    200            r           2606    16476    CaptAct CaptAct_NumberAct_key 
   CONSTRAINT     c   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_NumberAct_key" UNIQUE ("NumberAct");
 K   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_NumberAct_key";
       public            postgres    false    202            t           2606    16478    CaptAct CaptAct_NumberMK_key 
   CONSTRAINT     a   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_NumberMK_key" UNIQUE ("NumberMK");
 J   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_NumberMK_key";
       public            postgres    false    202            v           2606    16480    CaptAct CaptAct_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_pkey" PRIMARY KEY ("ID_CaptAct");
 B   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_pkey";
       public            postgres    false    202            x           2606    16482    CaptOrg CaptOrg_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public."CaptOrg"
    ADD CONSTRAINT "CaptOrg_pkey" PRIMARY KEY ("ID_CaptOrg");
 B   ALTER TABLE ONLY public."CaptOrg" DROP CONSTRAINT "CaptOrg_pkey";
       public            postgres    false    204            z           2606    16484    File File_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public."File"
    ADD CONSTRAINT "File_pkey" PRIMARY KEY ("ID");
 <   ALTER TABLE ONLY public."File" DROP CONSTRAINT "File_pkey";
       public            postgres    false    206            |           2606    16486    Function Function_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public."Function"
    ADD CONSTRAINT "Function_pkey" PRIMARY KEY ("ID_Function");
 D   ALTER TABLE ONLY public."Function" DROP CONSTRAINT "Function_pkey";
       public            postgres    false    207            ~           2606    16488    Locality Locality_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public."Locality"
    ADD CONSTRAINT "Locality_pkey" PRIMARY KEY ("ID_Locality");
 D   ALTER TABLE ONLY public."Locality" DROP CONSTRAINT "Locality_pkey";
       public            postgres    false    209            ?           2606    16490    Log Log_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public."Log"
    ADD CONSTRAINT "Log_pkey" PRIMARY KEY ("ID_Log");
 :   ALTER TABLE ONLY public."Log" DROP CONSTRAINT "Log_pkey";
       public            postgres    false    211            ?           2606    16492    Municipality Municipality_pkey 
   CONSTRAINT     o   ALTER TABLE ONLY public."Municipality"
    ADD CONSTRAINT "Municipality_pkey" PRIMARY KEY ("ID_Municipality");
 L   ALTER TABLE ONLY public."Municipality" DROP CONSTRAINT "Municipality_pkey";
       public            postgres    false    213            ?           2606    16494    OMSU OMSU_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public."OMSU"
    ADD CONSTRAINT "OMSU_pkey" PRIMARY KEY ("ID_OMSU");
 <   ALTER TABLE ONLY public."OMSU" DROP CONSTRAINT "OMSU_pkey";
       public            postgres    false    215            ?           2606    16496    Role Role_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public."Role"
    ADD CONSTRAINT "Role_pkey" PRIMARY KEY ("ID_Role");
 <   ALTER TABLE ONLY public."Role" DROP CONSTRAINT "Role_pkey";
       public            postgres    false    217            ?           2606    16498    User User_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public."User"
    ADD CONSTRAINT "User_pkey" PRIMARY KEY ("ID_User");
 <   ALTER TABLE ONLY public."User" DROP CONSTRAINT "User_pkey";
       public            postgres    false    219            ?           2606    16499    CaptAct CaptAct_CaptOrg_ID_fkey    FK CONSTRAINT     ?   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_CaptOrg_ID_fkey" FOREIGN KEY ("CaptOrg_ID") REFERENCES public."CaptOrg"("ID_CaptOrg") ON UPDATE CASCADE ON DELETE CASCADE;
 M   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_CaptOrg_ID_fkey";
       public          postgres    false    204    2936    202            ?           2606    16504    CaptAct CaptAct_File_ID_fkey    FK CONSTRAINT     ?   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_File_ID_fkey" FOREIGN KEY ("File_ID") REFERENCES public."File"("ID") NOT VALID;
 J   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_File_ID_fkey";
       public          postgres    false    206    202    2938            ?           2606    16509     CaptAct CaptAct_Locality_ID_fkey    FK CONSTRAINT     ?   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_Locality_ID_fkey" FOREIGN KEY ("Locality_ID") REFERENCES public."Locality"("ID_Locality") ON UPDATE CASCADE ON DELETE CASCADE;
 N   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_Locality_ID_fkey";
       public          postgres    false    202    209    2942            ?           2606    16514    CaptAct CaptAct_OMSU_ID_fkey    FK CONSTRAINT     ?   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_OMSU_ID_fkey" FOREIGN KEY ("OMSU_ID") REFERENCES public."OMSU"("ID_OMSU") ON UPDATE CASCADE ON DELETE CASCADE;
 J   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_OMSU_ID_fkey";
       public          postgres    false    215    2948    202            ?           2606    16519    Log Log_Action_ID_fkey    FK CONSTRAINT     ?   ALTER TABLE ONLY public."Log"
    ADD CONSTRAINT "Log_Action_ID_fkey" FOREIGN KEY ("Action_ID") REFERENCES public."Action"("ID_Action") ON UPDATE CASCADE ON DELETE CASCADE;
 D   ALTER TABLE ONLY public."Log" DROP CONSTRAINT "Log_Action_ID_fkey";
       public          postgres    false    2928    211    200            ?           2606    16529    Log Log_User_ID_fkey    FK CONSTRAINT     ?   ALTER TABLE ONLY public."Log"
    ADD CONSTRAINT "Log_User_ID_fkey" FOREIGN KEY ("User_ID") REFERENCES public."User"("ID_User") ON UPDATE CASCADE ON DELETE CASCADE;
 B   ALTER TABLE ONLY public."Log" DROP CONSTRAINT "Log_User_ID_fkey";
       public          postgres    false    219    211    2952            ?           2606    16534    OMSU OMSU_Municipality_ID_fkey    FK CONSTRAINT     ?   ALTER TABLE ONLY public."OMSU"
    ADD CONSTRAINT "OMSU_Municipality_ID_fkey" FOREIGN KEY ("Municipality_ID") REFERENCES public."Municipality"("ID_Municipality") NOT VALID;
 L   ALTER TABLE ONLY public."OMSU" DROP CONSTRAINT "OMSU_Municipality_ID_fkey";
       public          postgres    false    213    215    2946            ?           2606    16539    Role Role_Function_ID_fkey    FK CONSTRAINT     ?   ALTER TABLE ONLY public."Role"
    ADD CONSTRAINT "Role_Function_ID_fkey" FOREIGN KEY ("Function_ID") REFERENCES public."Function"("ID_Function") ON UPDATE CASCADE ON DELETE CASCADE;
 H   ALTER TABLE ONLY public."Role" DROP CONSTRAINT "Role_Function_ID_fkey";
       public          postgres    false    2940    207    217            ?           2606    16544    User User_CaptOrg_ID_fkey    FK CONSTRAINT     ?   ALTER TABLE ONLY public."User"
    ADD CONSTRAINT "User_CaptOrg_ID_fkey" FOREIGN KEY ("CaptOrg_ID") REFERENCES public."CaptOrg"("ID_CaptOrg") NOT VALID;
 G   ALTER TABLE ONLY public."User" DROP CONSTRAINT "User_CaptOrg_ID_fkey";
       public          postgres    false    2936    219    204            ?           2606    16549    User User_OMSU_ID_fkey    FK CONSTRAINT     ?   ALTER TABLE ONLY public."User"
    ADD CONSTRAINT "User_OMSU_ID_fkey" FOREIGN KEY ("OMSU_ID") REFERENCES public."OMSU"("ID_OMSU") NOT VALID;
 D   ALTER TABLE ONLY public."User" DROP CONSTRAINT "User_OMSU_ID_fkey";
       public          postgres    false    215    2948    219            ?           2606    16554    User User_Role_ID_fkey    FK CONSTRAINT     ?   ALTER TABLE ONLY public."User"
    ADD CONSTRAINT "User_Role_ID_fkey" FOREIGN KEY ("Role_ID") REFERENCES public."Role"("ID_Role") ON UPDATE CASCADE ON DELETE CASCADE;
 D   ALTER TABLE ONLY public."User" DROP CONSTRAINT "User_Role_ID_fkey";
       public          postgres    false    219    217    2950               A   x?3估?¾/l?????[/콰??V8?2?
l??,?!??e?y?h?l???1z\\\ ??.?         Q  x???AN?0E??)r? {???%8ACâ**?	q? ?@?fn??q?ԢIv?3?/?BJ??? i??z?_?_XRV?3??z??6??;ƺ6T?o??s??u??F2.H?O8??Ľ??*?k<?z?.R??DM#9??=??eY?c??4e,DlɱF????SI????u??m?Eh????r????8???-Y?nV?Hv84?Dx??s???u?ۆ??X?m?5;????3?f	?u䳰??#]?ܲM$?l???2??<[|??x???O?J???????F{??????i?˵^?!??Sh?G??X????N{?q?௧뼾????#?j         4   x?3??0?bÅ?6\?{aǅ?6\l???b??!?.)#.c\R?\1z\\\ ?2?            x?????? ? ?         B   x?3估???[?x???*\F??_?wa????.?P???bÅ}@? ?t???=... ??'?         C   x?8 ??1	Волгоград
2	Тюмень
3	Москва
\.


?? ?      !      x?????? ? ?      #   K   x?3??0?b???v\l?????.????ﻰUHl?? ?dm?@e@aC.#???Jq?3И+F??? ??J&      %   0   x?3??0?/,V0?4?2Cp?8???\c???k?i????? ?M?      '   
  x???MN?0???)|??.???p?6?؀@b?P+?Җ???{?77??R????*?y????8?5??d?VjYZ?????;il?c??aأ?<?/O⫉??4???٠???[??a???;Y???????ϊ:?^?P?x%?{~f??fO?5???-{?p?<?>????i??e??t	%??՜???9xy??f?Z!?????
???P}???N???.(???`Ú?0????
?n??????%?4?s?&i??+?q;???ͽ      )   K   x?3??M,)qN,*I-BbsZp?ssq&??d???V"X i#???!gV~F?Kj*?Ir?rr??qqq ?u{     