PGDMP         !                z            CaptAct    13.6    13.6 \    -           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            .           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            /           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            0           1262    17136    CaptAct    DATABASE     f   CREATE DATABASE "CaptAct" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "CaptAct";
                postgres    false            �            1259    17137    Action    TABLE     l   CREATE TABLE public."Action" (
    "ID_Action" integer NOT NULL,
    "ActionName" character(20) NOT NULL
);
    DROP TABLE public."Action";
       public         heap    postgres    false            �            1259    17140    Action_ID_Action_seq    SEQUENCE     �   CREATE SEQUENCE public."Action_ID_Action_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."Action_ID_Action_seq";
       public          postgres    false    200            1           0    0    Action_ID_Action_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public."Action_ID_Action_seq" OWNED BY public."Action"."ID_Action";
          public          postgres    false    201            �            1259    17142    CaptAct    TABLE     g  CREATE TABLE public."CaptAct" (
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
    "File_ID" integer,
    CONSTRAINT "CaptAct_CaptAnimals_check" CHECK (("CaptAnimals" >= 0)),
    CONSTRAINT "CaptAct_CaptCats_check" CHECK (("CaptCats" >= 0)),
    CONSTRAINT "CaptAct_CaptDogs_check" CHECK (("CaptDogs" >= 0))
);
    DROP TABLE public."CaptAct";
       public         heap    postgres    false            �            1259    17148    CaptAct_ID_CaptAct_seq    SEQUENCE     �   CREATE SEQUENCE public."CaptAct_ID_CaptAct_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public."CaptAct_ID_CaptAct_seq";
       public          postgres    false    202            2           0    0    CaptAct_ID_CaptAct_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public."CaptAct_ID_CaptAct_seq" OWNED BY public."CaptAct"."ID_CaptAct";
          public          postgres    false    203            �            1259    17150    CaptOrg    TABLE     V   CREATE TABLE public."CaptOrg" (
    "ID_CaptOrg" integer NOT NULL,
    "Name" text
);
    DROP TABLE public."CaptOrg";
       public         heap    postgres    false            �            1259    17156    CaptOrg_ID_CaptOrg_seq    SEQUENCE     �   CREATE SEQUENCE public."CaptOrg_ID_CaptOrg_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public."CaptOrg_ID_CaptOrg_seq";
       public          postgres    false    204            3           0    0    CaptOrg_ID_CaptOrg_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public."CaptOrg_ID_CaptOrg_seq" OWNED BY public."CaptOrg"."ID_CaptOrg";
          public          postgres    false    205            �            1259    17158    File    TABLE     ~   CREATE TABLE public."File" (
    "ID" bigint NOT NULL,
    "Name" character varying(50),
    "Path" character varying(100)
);
    DROP TABLE public."File";
       public         heap    postgres    false            �            1259    17161    Function    TABLE     i   CREATE TABLE public."Function" (
    "ID_Function" integer NOT NULL,
    "FunctionName" character(40)
);
    DROP TABLE public."Function";
       public         heap    postgres    false            �            1259    17164    Function_ID_Function_seq    SEQUENCE     �   CREATE SEQUENCE public."Function_ID_Function_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public."Function_ID_Function_seq";
       public          postgres    false    207            4           0    0    Function_ID_Function_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public."Function_ID_Function_seq" OWNED BY public."Function"."ID_Function";
          public          postgres    false    208            �            1259    17166    Locality    TABLE     X   CREATE TABLE public."Locality" (
    "ID_Locality" integer NOT NULL,
    "Name" text
);
    DROP TABLE public."Locality";
       public         heap    postgres    false            �            1259    17172    Locality_ID_Locality_seq    SEQUENCE     �   CREATE SEQUENCE public."Locality_ID_Locality_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public."Locality_ID_Locality_seq";
       public          postgres    false    209            5           0    0    Locality_ID_Locality_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public."Locality_ID_Locality_seq" OWNED BY public."Locality"."ID_Locality";
          public          postgres    false    210            �            1259    17174    Log    TABLE     �   CREATE TABLE public."Log" (
    "ID_Log" integer NOT NULL,
    "ActionDate" timestamp without time zone NOT NULL,
    "User_ID" integer NOT NULL,
    "Action_ID" integer NOT NULL,
    "CaptAct_ID" integer NOT NULL
);
    DROP TABLE public."Log";
       public         heap    postgres    false            �            1259    17177    Log_ID_Log_seq    SEQUENCE     �   CREATE SEQUENCE public."Log_ID_Log_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public."Log_ID_Log_seq";
       public          postgres    false    211            6           0    0    Log_ID_Log_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public."Log_ID_Log_seq" OWNED BY public."Log"."ID_Log";
          public          postgres    false    212            �            1259    17179    Municipality    TABLE     `   CREATE TABLE public."Municipality" (
    "ID_Municipality" integer NOT NULL,
    "Name" text
);
 "   DROP TABLE public."Municipality";
       public         heap    postgres    false            �            1259    17185     Municipality_ID_Municipality_seq    SEQUENCE     �   CREATE SEQUENCE public."Municipality_ID_Municipality_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 9   DROP SEQUENCE public."Municipality_ID_Municipality_seq";
       public          postgres    false    213            7           0    0     Municipality_ID_Municipality_seq    SEQUENCE OWNED BY     k   ALTER SEQUENCE public."Municipality_ID_Municipality_seq" OWNED BY public."Municipality"."ID_Municipality";
          public          postgres    false    214            �            1259    17187    OMSU    TABLE     x   CREATE TABLE public."OMSU" (
    "ID_OMSU" integer NOT NULL,
    "Name" text,
    "Municipality_ID" integer NOT NULL
);
    DROP TABLE public."OMSU";
       public         heap    postgres    false            �            1259    17193    OMSU_ID_OMSU_seq    SEQUENCE     �   CREATE SEQUENCE public."OMSU_ID_OMSU_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public."OMSU_ID_OMSU_seq";
       public          postgres    false    215            8           0    0    OMSU_ID_OMSU_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public."OMSU_ID_OMSU_seq" OWNED BY public."OMSU"."ID_OMSU";
          public          postgres    false    216            �            1259    17195    Role    TABLE     �   CREATE TABLE public."Role" (
    "ID_Role" integer NOT NULL,
    "RoleName" character(70),
    "Function_ID" integer NOT NULL
);
    DROP TABLE public."Role";
       public         heap    postgres    false            �            1259    17198    Role_ID_Role_seq    SEQUENCE     �   CREATE SEQUENCE public."Role_ID_Role_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public."Role_ID_Role_seq";
       public          postgres    false    217            9           0    0    Role_ID_Role_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public."Role_ID_Role_seq" OWNED BY public."Role"."ID_Role";
          public          postgres    false    218            �            1259    17200    User    TABLE     �   CREATE TABLE public."User" (
    "ID_User" integer NOT NULL,
    "Login" character varying(50) NOT NULL,
    "Password" character varying(25) NOT NULL,
    "Role_ID" integer NOT NULL,
    "OMSU_ID" integer,
    "CaptOrg_ID" integer
);
    DROP TABLE public."User";
       public         heap    postgres    false            �            1259    17203    User_ID_User_seq    SEQUENCE     �   CREATE SEQUENCE public."User_ID_User_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public."User_ID_User_seq";
       public          postgres    false    219            :           0    0    User_ID_User_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public."User_ID_User_seq" OWNED BY public."User"."ID_User";
          public          postgres    false    220            `           2604    17208    Action ID_Action    DEFAULT     z   ALTER TABLE ONLY public."Action" ALTER COLUMN "ID_Action" SET DEFAULT nextval('public."Action_ID_Action_seq"'::regclass);
 C   ALTER TABLE public."Action" ALTER COLUMN "ID_Action" DROP DEFAULT;
       public          postgres    false    201    200            a           2604    17209    CaptAct ID_CaptAct    DEFAULT     ~   ALTER TABLE ONLY public."CaptAct" ALTER COLUMN "ID_CaptAct" SET DEFAULT nextval('public."CaptAct_ID_CaptAct_seq"'::regclass);
 E   ALTER TABLE public."CaptAct" ALTER COLUMN "ID_CaptAct" DROP DEFAULT;
       public          postgres    false    203    202            e           2604    17210    CaptOrg ID_CaptOrg    DEFAULT     ~   ALTER TABLE ONLY public."CaptOrg" ALTER COLUMN "ID_CaptOrg" SET DEFAULT nextval('public."CaptOrg_ID_CaptOrg_seq"'::regclass);
 E   ALTER TABLE public."CaptOrg" ALTER COLUMN "ID_CaptOrg" DROP DEFAULT;
       public          postgres    false    205    204            f           2604    17211    Function ID_Function    DEFAULT     �   ALTER TABLE ONLY public."Function" ALTER COLUMN "ID_Function" SET DEFAULT nextval('public."Function_ID_Function_seq"'::regclass);
 G   ALTER TABLE public."Function" ALTER COLUMN "ID_Function" DROP DEFAULT;
       public          postgres    false    208    207            g           2604    17212    Locality ID_Locality    DEFAULT     �   ALTER TABLE ONLY public."Locality" ALTER COLUMN "ID_Locality" SET DEFAULT nextval('public."Locality_ID_Locality_seq"'::regclass);
 G   ALTER TABLE public."Locality" ALTER COLUMN "ID_Locality" DROP DEFAULT;
       public          postgres    false    210    209            h           2604    17213 
   Log ID_Log    DEFAULT     n   ALTER TABLE ONLY public."Log" ALTER COLUMN "ID_Log" SET DEFAULT nextval('public."Log_ID_Log_seq"'::regclass);
 =   ALTER TABLE public."Log" ALTER COLUMN "ID_Log" DROP DEFAULT;
       public          postgres    false    212    211            i           2604    17214    Municipality ID_Municipality    DEFAULT     �   ALTER TABLE ONLY public."Municipality" ALTER COLUMN "ID_Municipality" SET DEFAULT nextval('public."Municipality_ID_Municipality_seq"'::regclass);
 O   ALTER TABLE public."Municipality" ALTER COLUMN "ID_Municipality" DROP DEFAULT;
       public          postgres    false    214    213            j           2604    17215    OMSU ID_OMSU    DEFAULT     r   ALTER TABLE ONLY public."OMSU" ALTER COLUMN "ID_OMSU" SET DEFAULT nextval('public."OMSU_ID_OMSU_seq"'::regclass);
 ?   ALTER TABLE public."OMSU" ALTER COLUMN "ID_OMSU" DROP DEFAULT;
       public          postgres    false    216    215            k           2604    17216    Role ID_Role    DEFAULT     r   ALTER TABLE ONLY public."Role" ALTER COLUMN "ID_Role" SET DEFAULT nextval('public."Role_ID_Role_seq"'::regclass);
 ?   ALTER TABLE public."Role" ALTER COLUMN "ID_Role" DROP DEFAULT;
       public          postgres    false    218    217            l           2604    17217    User ID_User    DEFAULT     r   ALTER TABLE ONLY public."User" ALTER COLUMN "ID_User" SET DEFAULT nextval('public."User_ID_User_seq"'::regclass);
 ?   ALTER TABLE public."User" ALTER COLUMN "ID_User" DROP DEFAULT;
       public          postgres    false    220    219                      0    17137    Action 
   TABLE DATA           =   COPY public."Action" ("ID_Action", "ActionName") FROM stdin;
    public          postgres    false    200   �m                 0    17142    CaptAct 
   TABLE DATA           �   COPY public."CaptAct" ("ID_CaptAct", "NumberMK", "DateMK", "NumberAct", "CaptCats", "CaptDogs", "CaptAnimals", "CaptDate", "CaptPurpose", "Municipality_ID", "OMSU_ID", "CaptOrg_ID", "Locality_ID", "File_ID") FROM stdin;
    public          postgres    false    202   �m                 0    17150    CaptOrg 
   TABLE DATA           9   COPY public."CaptOrg" ("ID_CaptOrg", "Name") FROM stdin;
    public          postgres    false    204   �m                 0    17158    File 
   TABLE DATA           6   COPY public."File" ("ID", "Name", "Path") FROM stdin;
    public          postgres    false    206   �m                 0    17161    Function 
   TABLE DATA           C   COPY public."Function" ("ID_Function", "FunctionName") FROM stdin;
    public          postgres    false    207   �m                 0    17166    Locality 
   TABLE DATA           ;   COPY public."Locality" ("ID_Locality", "Name") FROM stdin;
    public          postgres    false    209   n       !          0    17174    Log 
   TABLE DATA           ]   COPY public."Log" ("ID_Log", "ActionDate", "User_ID", "Action_ID", "CaptAct_ID") FROM stdin;
    public          postgres    false    211   4n       #          0    17179    Municipality 
   TABLE DATA           C   COPY public."Municipality" ("ID_Municipality", "Name") FROM stdin;
    public          postgres    false    213   Qn       %          0    17187    OMSU 
   TABLE DATA           F   COPY public."OMSU" ("ID_OMSU", "Name", "Municipality_ID") FROM stdin;
    public          postgres    false    215   nn       '          0    17195    Role 
   TABLE DATA           F   COPY public."Role" ("ID_Role", "RoleName", "Function_ID") FROM stdin;
    public          postgres    false    217   �n       )          0    17200    User 
   TABLE DATA           d   COPY public."User" ("ID_User", "Login", "Password", "Role_ID", "OMSU_ID", "CaptOrg_ID") FROM stdin;
    public          postgres    false    219   �n       ;           0    0    Action_ID_Action_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."Action_ID_Action_seq"', 1, false);
          public          postgres    false    201            <           0    0    CaptAct_ID_CaptAct_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public."CaptAct_ID_CaptAct_seq"', 1, false);
          public          postgres    false    203            =           0    0    CaptOrg_ID_CaptOrg_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public."CaptOrg_ID_CaptOrg_seq"', 1, false);
          public          postgres    false    205            >           0    0    Function_ID_Function_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public."Function_ID_Function_seq"', 1, false);
          public          postgres    false    208            ?           0    0    Locality_ID_Locality_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public."Locality_ID_Locality_seq"', 1, false);
          public          postgres    false    210            @           0    0    Log_ID_Log_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public."Log_ID_Log_seq"', 1, false);
          public          postgres    false    212            A           0    0     Municipality_ID_Municipality_seq    SEQUENCE SET     Q   SELECT pg_catalog.setval('public."Municipality_ID_Municipality_seq"', 1, false);
          public          postgres    false    214            B           0    0    OMSU_ID_OMSU_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public."OMSU_ID_OMSU_seq"', 1, false);
          public          postgres    false    216            C           0    0    Role_ID_Role_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public."Role_ID_Role_seq"', 1, false);
          public          postgres    false    218            D           0    0    User_ID_User_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public."User_ID_User_seq"', 1, false);
          public          postgres    false    220            n           2606    17219    Action Action_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public."Action"
    ADD CONSTRAINT "Action_pkey" PRIMARY KEY ("ID_Action");
 @   ALTER TABLE ONLY public."Action" DROP CONSTRAINT "Action_pkey";
       public            postgres    false    200            p           2606    17221    CaptAct CaptAct_NumberAct_key 
   CONSTRAINT     c   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_NumberAct_key" UNIQUE ("NumberAct");
 K   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_NumberAct_key";
       public            postgres    false    202            r           2606    17223    CaptAct CaptAct_NumberMK_key 
   CONSTRAINT     a   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_NumberMK_key" UNIQUE ("NumberMK");
 J   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_NumberMK_key";
       public            postgres    false    202            t           2606    17225    CaptAct CaptAct_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_pkey" PRIMARY KEY ("ID_CaptAct");
 B   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_pkey";
       public            postgres    false    202            v           2606    17227    CaptOrg CaptOrg_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public."CaptOrg"
    ADD CONSTRAINT "CaptOrg_pkey" PRIMARY KEY ("ID_CaptOrg");
 B   ALTER TABLE ONLY public."CaptOrg" DROP CONSTRAINT "CaptOrg_pkey";
       public            postgres    false    204            x           2606    17229    File File_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public."File"
    ADD CONSTRAINT "File_pkey" PRIMARY KEY ("ID");
 <   ALTER TABLE ONLY public."File" DROP CONSTRAINT "File_pkey";
       public            postgres    false    206            z           2606    17231    Function Function_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public."Function"
    ADD CONSTRAINT "Function_pkey" PRIMARY KEY ("ID_Function");
 D   ALTER TABLE ONLY public."Function" DROP CONSTRAINT "Function_pkey";
       public            postgres    false    207            |           2606    17233    Locality Locality_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public."Locality"
    ADD CONSTRAINT "Locality_pkey" PRIMARY KEY ("ID_Locality");
 D   ALTER TABLE ONLY public."Locality" DROP CONSTRAINT "Locality_pkey";
       public            postgres    false    209            ~           2606    17235    Log Log_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public."Log"
    ADD CONSTRAINT "Log_pkey" PRIMARY KEY ("ID_Log");
 :   ALTER TABLE ONLY public."Log" DROP CONSTRAINT "Log_pkey";
       public            postgres    false    211            �           2606    17237    Municipality Municipality_pkey 
   CONSTRAINT     o   ALTER TABLE ONLY public."Municipality"
    ADD CONSTRAINT "Municipality_pkey" PRIMARY KEY ("ID_Municipality");
 L   ALTER TABLE ONLY public."Municipality" DROP CONSTRAINT "Municipality_pkey";
       public            postgres    false    213            �           2606    17239    OMSU OMSU_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public."OMSU"
    ADD CONSTRAINT "OMSU_pkey" PRIMARY KEY ("ID_OMSU");
 <   ALTER TABLE ONLY public."OMSU" DROP CONSTRAINT "OMSU_pkey";
       public            postgres    false    215            �           2606    17241    Role Role_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public."Role"
    ADD CONSTRAINT "Role_pkey" PRIMARY KEY ("ID_Role");
 <   ALTER TABLE ONLY public."Role" DROP CONSTRAINT "Role_pkey";
       public            postgres    false    217            �           2606    17243    User User_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public."User"
    ADD CONSTRAINT "User_pkey" PRIMARY KEY ("ID_User");
 <   ALTER TABLE ONLY public."User" DROP CONSTRAINT "User_pkey";
       public            postgres    false    219            �           2606    17244    CaptAct CaptAct_CaptOrg_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_CaptOrg_ID_fkey" FOREIGN KEY ("CaptOrg_ID") REFERENCES public."CaptOrg"("ID_CaptOrg") ON UPDATE CASCADE ON DELETE CASCADE;
 M   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_CaptOrg_ID_fkey";
       public          postgres    false    202    2934    204            �           2606    17249    CaptAct CaptAct_File_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_File_ID_fkey" FOREIGN KEY ("File_ID") REFERENCES public."File"("ID") NOT VALID;
 J   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_File_ID_fkey";
       public          postgres    false    206    202    2936            �           2606    17254     CaptAct CaptAct_Locality_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_Locality_ID_fkey" FOREIGN KEY ("Locality_ID") REFERENCES public."Locality"("ID_Locality") ON UPDATE CASCADE ON DELETE CASCADE;
 N   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_Locality_ID_fkey";
       public          postgres    false    2940    202    209            �           2606    17259 $   CaptAct CaptAct_Municipality_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_Municipality_ID_fkey" FOREIGN KEY ("Municipality_ID") REFERENCES public."Municipality"("ID_Municipality") ON UPDATE CASCADE ON DELETE CASCADE;
 R   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_Municipality_ID_fkey";
       public          postgres    false    202    213    2944            �           2606    17264    CaptAct CaptAct_OMSU_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."CaptAct"
    ADD CONSTRAINT "CaptAct_OMSU_ID_fkey" FOREIGN KEY ("OMSU_ID") REFERENCES public."OMSU"("ID_OMSU") ON UPDATE CASCADE ON DELETE CASCADE;
 J   ALTER TABLE ONLY public."CaptAct" DROP CONSTRAINT "CaptAct_OMSU_ID_fkey";
       public          postgres    false    202    215    2946            �           2606    17269    Log Log_Action_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Log"
    ADD CONSTRAINT "Log_Action_ID_fkey" FOREIGN KEY ("Action_ID") REFERENCES public."Action"("ID_Action") ON UPDATE CASCADE ON DELETE CASCADE;
 D   ALTER TABLE ONLY public."Log" DROP CONSTRAINT "Log_Action_ID_fkey";
       public          postgres    false    211    2926    200            �           2606    17274    Log Log_CaptAct_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Log"
    ADD CONSTRAINT "Log_CaptAct_ID_fkey" FOREIGN KEY ("CaptAct_ID") REFERENCES public."CaptAct"("ID_CaptAct") ON UPDATE CASCADE ON DELETE CASCADE;
 E   ALTER TABLE ONLY public."Log" DROP CONSTRAINT "Log_CaptAct_ID_fkey";
       public          postgres    false    202    211    2932            �           2606    17279    Log Log_User_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Log"
    ADD CONSTRAINT "Log_User_ID_fkey" FOREIGN KEY ("User_ID") REFERENCES public."User"("ID_User") ON UPDATE CASCADE ON DELETE CASCADE;
 B   ALTER TABLE ONLY public."Log" DROP CONSTRAINT "Log_User_ID_fkey";
       public          postgres    false    219    2950    211            �           2606    17284    OMSU OMSU_Municipality_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."OMSU"
    ADD CONSTRAINT "OMSU_Municipality_ID_fkey" FOREIGN KEY ("Municipality_ID") REFERENCES public."Municipality"("ID_Municipality") NOT VALID;
 L   ALTER TABLE ONLY public."OMSU" DROP CONSTRAINT "OMSU_Municipality_ID_fkey";
       public          postgres    false    2944    213    215            �           2606    17289    Role Role_Function_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Role"
    ADD CONSTRAINT "Role_Function_ID_fkey" FOREIGN KEY ("Function_ID") REFERENCES public."Function"("ID_Function") ON UPDATE CASCADE ON DELETE CASCADE;
 H   ALTER TABLE ONLY public."Role" DROP CONSTRAINT "Role_Function_ID_fkey";
       public          postgres    false    2938    207    217            �           2606    17294    User User_CaptOrg_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."User"
    ADD CONSTRAINT "User_CaptOrg_ID_fkey" FOREIGN KEY ("CaptOrg_ID") REFERENCES public."CaptOrg"("ID_CaptOrg") NOT VALID;
 G   ALTER TABLE ONLY public."User" DROP CONSTRAINT "User_CaptOrg_ID_fkey";
       public          postgres    false    219    2934    204            �           2606    17299    User User_OMSU_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."User"
    ADD CONSTRAINT "User_OMSU_ID_fkey" FOREIGN KEY ("OMSU_ID") REFERENCES public."OMSU"("ID_OMSU") NOT VALID;
 D   ALTER TABLE ONLY public."User" DROP CONSTRAINT "User_OMSU_ID_fkey";
       public          postgres    false    219    215    2946            �           2606    17304    User User_Role_ID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."User"
    ADD CONSTRAINT "User_Role_ID_fkey" FOREIGN KEY ("Role_ID") REFERENCES public."Role"("ID_Role") ON UPDATE CASCADE ON DELETE CASCADE;
 D   ALTER TABLE ONLY public."User" DROP CONSTRAINT "User_Role_ID_fkey";
       public          postgres    false    2948    217    219                  x������ � �            x������ � �            x������ � �            x������ � �            x������ � �            x������ � �      !      x������ � �      #      x������ � �      %      x������ � �      '      x������ � �      )      x������ � �     