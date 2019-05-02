\providecommand{\myrootdir}{}
\providecommand{\mylanguage}{en}

\NeedsTeXFormat{LaTeX2e}
\ProvidesClass{\myrootdir/zyx/mythesis}[2016/12/31 My Thesis Template]

%% Pass page layout to the underlying layout class
\DeclareOption{oneside}{
  \PassOptionsToClass{\CurrentOption}{scrbook}
}
\DeclareOption{twoside}{
  \PassOptionsToClass{\CurrentOption}{scrbook}
}

\DeclareOption{de}{
  \renewcommand{\mylanguage}{de}
}

%% Fallback
\DeclareOption*{
  \ClassWarning{mythesis}{Unknown option '\CurrentOption'}
}

% Process given options
\ProcessOptions\relax

% Load base class
\LoadClass[headsepline,footsepline,fontsize=11pt,a4paper,listof=totoc,bibliography=totoc]{scrbook}
\setkomafont{disposition}{\normalfont\bfseries} % use serif font for headings
\linespread{1.05} % adjust line spread for mathpazo font

% Fix figure numbering
% https://tex.stackexchange.com/questions/35953/running-figure-numbering
\KOMAoptions{numbers=noendperiod}

% Remove spacing before chapter title
\renewcommand{\chapterheadstartvskip}{}

% Load additional packages and commands.
\RequirePackage{scrpage2}
% scr compatibility with KOMA script
\usepackage{scrhack}
\usepackage{\myrootdir/zyx/mypackages}

% Load all user config variables
\usepackage{\myrootdir/mini/myconfig}
% And store them into title and author of the document
\title{\myTitle}
\author{\myAuthor}
\hypersetup{pdfsubject={\myThesisType}}

\endinput
